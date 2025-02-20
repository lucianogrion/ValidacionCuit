public static bool ValidarCUIT(string source)
        {            
            int suma;
            int resto;
            int verif;
            string nro = source;
            try
            {
                if (nro.Length == 0)
                {
                    return true;
                }

                //if (nro.Length == 11)
                //{
                //    nro = nro.Insert(10, "-");
                //    nro = nro.Insert(2, "-");
                //}

                if (nro[2] != '-' || nro[11] != '-')
                {
                    return false;
                }

                while (true)
                {
                    suma = (
                            int.Parse(nro[0].ToString()) * 5 +
                            int.Parse(nro[1].ToString()) * 4 +
                            int.Parse(nro[3].ToString()) * 3 +
                            int.Parse(nro[4].ToString()) * 2 +
                            int.Parse(nro[5].ToString()) * 7 +
                            int.Parse(nro[6].ToString()) * 6 +
                            int.Parse(nro[7].ToString()) * 5 +
                            int.Parse(nro[8].ToString()) * 4 +
                            int.Parse(nro[9].ToString()) * 3 +
                            int.Parse(nro[10].ToString()) * 2
                            );


                    System.Math.DivRem(suma, 11, out  resto); //resto = suma % 11;

                    if (resto == 0)
                    {
                        verif = 0;
                        break;
                    }

                    else if (resto == 1 && (int.Parse(nro[1].ToString()) == 0 || int.Parse(nro[6].ToString()) == 7))
                    {
                        char[] miChar = new char[11];
                        miChar = nro.ToCharArray();
                        miChar[1] = '4';
                        nro = miChar.ToString();
                        continue;
                    }

                    else
                    {
                        verif = 11 - resto;
                        break;
                    }
                }


                if (int.Parse(nro[12].ToString()) == verif)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch (Exception ex)
            {
                return false;
            }

        }//