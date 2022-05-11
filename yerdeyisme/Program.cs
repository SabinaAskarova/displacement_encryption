using System;

namespace yerdeyisme
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Encryption
            Console.WriteLine("Sifrelenecek metni daxil edin:");
            string message = Console.ReadLine();
            if (message.Length < 3)
            {
                char[] c = message.ToCharArray();
                char tmp;
                tmp = c[0];
                c[0] = c[1];
                c[1] = tmp;
                string netice = null;
                for (int i = 0; i < c.Length; i++)
                {
                    netice += c[i];
                }
                Console.WriteLine(netice);
            }
            else
            {
                int col = 2;//2 int.Parse(Console.ReadLine());
                int row;
                row = message.Length / col;
                if (message.Length % col != 0)
                {
                    row += 1;
                }
                char[,] matris = new char[row, col];

                int k = 0, flag = 0;
                for (int i = 0; i < row; i++)
                {
                    if (flag == 1)
                    {
                        break;
                    }
                    for (int j = 0; j < col; j++)
                    {
                        if (message.Length - 1 < k)
                        {
                            flag = 1;
                            matris[i, j] = '_';
                        }
                        else
                        {
                            matris[i, j] = message[k++];
                        }
                    }
                }

                string sifrlenmisMetn = null;
                for (int i = 0; i < col; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        if (matris[j, i] == '_')
                        {
                            continue;
                        }
                        sifrlenmisMetn += matris[j, i];
                    }
                }
                Console.WriteLine("Sifrelenmis metn: " + sifrlenmisMetn);
                #endregion

                #region Decryption
                flag = 0; k = 0;
                Console.WriteLine("Desifrlenecek metni daxil edin:");
                string desifrmetn = Console.ReadLine();
                for (int i = 0; i < col; i++)
                {
                    if (flag == 1)
                    {
                        break;
                    }
                    for (int j = 0; j < row; j++)
                    {
                        if (desifrmetn.Length - 1 < k)
                        {
                            flag = 1;
                            matris[j, i] = '_';
                        }
                        else
                        {
                            matris[j, i] = desifrmetn[k++];
                        }
                    }
                }

                string desifrlenmisMetn = null;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (matris[i, j] == '_')
                        {
                            continue;
                        }
                        desifrlenmisMetn += matris[i, j];
                    }
                }
                Console.WriteLine("Desifre edilmis metn: " + desifrlenmisMetn);
            }
            #endregion

            Console.ReadKey();
        }
    }
}
