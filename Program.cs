using System;
using System.Text;

namespace cipher
//alphabet to number. 27+i - number/random number. quotient to alphabet will be in the middle and right extreme is remainder
{
    class Program

    {
        static char Converter(int m)
        {
            char tobereturned = ' ';
            switch (m)
            {
                case 1:
                    tobereturned = 'a';
                    break;
                case 2:
                    tobereturned = 'b';
                    break;
                case 3:
                    tobereturned = 'c';
                    break;
                case 4:
                    tobereturned = 'd';
                    break;
                case 5:
                    tobereturned = 'e';
                    break;
                case 6:
                    tobereturned = 'f';
                    break;
                case 7:
                    tobereturned = 'g';
                    break;
                case 8:
                    tobereturned = 'h';
                    break;
                case 9:
                    tobereturned = 'i';
                    break;
                case 10:
                    tobereturned = 'j';
                    break;
                case 11:
                    tobereturned = 'k';
                    break;
                case 12:
                    tobereturned = 'l';
                    break;
                case 13:
                    tobereturned = 'm';
                    break;
                case 14:
                    tobereturned = 'n';
                    break;
                case 15:
                    tobereturned = 'o';
                    break;
                case 16:
                    tobereturned = 'p';
                    break;
                case 17:
                    tobereturned = 'q';
                    break;
                case 18:
                    tobereturned = 'r';
                    break;
                case 19:
                    tobereturned = 's';
                    break;
                case 20:
                    tobereturned = 't';
                    break;
                case 21:
                    tobereturned = 'u';
                    break;
                case 22:
                    tobereturned = 'v';
                    break;
                case 23:
                    tobereturned = 'w';
                    break;
                case 24:
                    tobereturned = 'x';
                    break;
                case 25:
                    tobereturned = 'y';
                    break;
                case 26:
                    tobereturned = 'z';
                    break;

            }
            return tobereturned;

        }
        static int Converter2(char n)
        {
            int tobereturned2 = ' ';
            switch (n)
            {
                case 'a':
                    tobereturned2 = 1;
                    break;
                case 'b':
                    tobereturned2 = 2;
                    break;
                case 'c':
                    tobereturned2 = 3;
                    break;
                case 'd':
                    tobereturned2 = 4;
                    break;
                case 'e':
                    tobereturned2 = 5;
                    break;
                case 'f':
                    tobereturned2 = 6;
                    break;
                case 'g':
                    tobereturned2 = 7;
                    break;
                case 'h':
                    tobereturned2 = 8;
                    break;
                case 'i':
                    tobereturned2 = 9;
                    break;
                case 'j':
                    tobereturned2 = 10;
                    break;
                case 'k':
                    tobereturned2 = 11;
                    break;
                case 'l':
                    tobereturned2 = 12;
                    break;
                case 'm':
                    tobereturned2 = 13;
                    break;
                case 'n':
                    tobereturned2 = 14;
                    break;
                case 'o':
                    tobereturned2 = 15;
                    break;
                case 'p':
                    tobereturned2 = 16;
                    break;
                case 'q':
                    tobereturned2 = 17;
                    break;
                case 'r':
                    tobereturned2 = 18;
                    break;
                case 's':
                    tobereturned2 = 19;
                    break;
                case 't':
                    tobereturned2 = 20;
                    break;
                case 'u':
                    tobereturned2 = 21;
                    break;
                case 'v':
                    tobereturned2 = 22;
                    break;
                case 'w':
                    tobereturned2 = 23;
                    break;
                case 'x':
                    tobereturned2 = 24;
                    break;
                case 'y':
                    tobereturned2 = 25;
                    break;
                case 'z':
                    tobereturned2 = 26;
                    break;

            }
            return tobereturned2;
            static object Encoder(int response2 = 1)
            {
                Console.WriteLine("what is the sentence you want to encode");

                string encode = Console.ReadLine();
                string encode3 = encode.ToLower();
                int length_of_encode = encode3.Length;
                char[] encode2 = encode3.ToCharArray();
                Random rng = new Random();
                int randomnumber;
                int middle = 0;
                int remainder = 0;

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < length_of_encode; i++)
                {
                    randomnumber = rng.Next(1, 9);
                    switch (encode2[i])
                    {
                        case 'a':
                            middle = (27 + i - 1) / randomnumber;
                            remainder = (27 + i - 1) % randomnumber;
                            break;
                        case 'b':
                            middle = (27 + i - 2) / randomnumber;
                            remainder = (27 + i - 2) % randomnumber;
                            break;
                        case 'c':
                            middle = (27 + i - 3) / randomnumber;
                            remainder = (27 + i - 3) % randomnumber;
                            break;
                        case 'd':
                            remainder = (27 + i - 4) % randomnumber;
                            middle = (27 + i - 4) / randomnumber;
                            break;
                        case 'e':
                            middle = (27 + i - 5) / randomnumber;
                            remainder = (27 + i - 5) % randomnumber;
                            break;
                        case 'f':
                            middle = (27 + i - 6) / randomnumber;
                            remainder = (27 + i - 6) % randomnumber;
                            break;
                        case 'g':
                            remainder = (27 + i - 7) % randomnumber;
                            middle = (27 + i - 7) / randomnumber;
                            break;
                        case 'h':
                            remainder = (27 + i - 8) % randomnumber;
                            middle = (27 + i - 8) / randomnumber;
                            break;
                        case 'i':
                            remainder = (27 + i - 9) % randomnumber;
                            middle = (27 + i - 9) / randomnumber;
                            break;
                        case 'j':
                            remainder = (27 + i - 10) % randomnumber;
                            middle = (27 + i - 10) / randomnumber;
                            break;
                        case 'k':
                            remainder = (27 + i - 11) % randomnumber;
                            middle = (27 + i - 11) / randomnumber;
                            break;
                        case 'l':
                            remainder = (27 + i - 12) % randomnumber;
                            middle = (27 + i - 12) / randomnumber;
                            break;
                        case 'm':
                            remainder = (27 + i - 13) % randomnumber;
                            middle = (27 + i - 13) / randomnumber;
                            break;
                        case 'n':
                            remainder = (27 + i - 14) % randomnumber;
                            middle = (27 + i - 14) / randomnumber;
                            break;
                        case 'o':
                            remainder = (27 + i - 15) % randomnumber;
                            middle = (27 + i - 15) / randomnumber;
                            break;
                        case 'p':
                            remainder = (27 + i - 16) % randomnumber;
                            middle = ((27 + i) - 16) / randomnumber;
                            break;
                        case 'q':
                            middle = ((27 + i) - 17) / randomnumber;
                            remainder = (27 + i - 17) % randomnumber;

                            break;
                        case 'r':
                            middle = ((27 + i) - 18) / randomnumber;
                            remainder = (27 + i - 18) % randomnumber;
                            break;
                        case 's':
                            middle = ((27 + i) - 19) / randomnumber;
                            remainder = (27 + i - 19) % randomnumber;
                            break;
                        case 't':
                            middle = ((27 + i) - 20) / randomnumber;
                            remainder = (27 + i - 20) % randomnumber;
                            break;
                        case 'u':
                            middle = ((27 + i) - 21) / randomnumber;
                            remainder = (27 + i - 21) % randomnumber;
                            break;
                        case 'v':
                            middle = ((27 + i) - 22) / randomnumber;
                            remainder = (27 + i - 22) % randomnumber;
                            break;
                        case 'w':
                            middle = ((27 + i) - 23) / randomnumber;
                            remainder = (27 + i - 23) % randomnumber;
                            break;
                        case 'x':
                            middle = ((27 + i) - 24) / randomnumber;
                            remainder = (27 + i - 25) % randomnumber;
                            break;
                        case 'y':
                            remainder = (27 + i - 25) % randomnumber;
                            middle = ((27 + i) - 25) / randomnumber;
                            break;
                        case 'z':
                            remainder = (27 + i - 26) % randomnumber;
                            middle = ((27 + i) - 26) / randomnumber;
                            break;


                    }
                    sb.Append(randomnumber);
                    sb.Append(Converter(middle));
                    sb.Append(remainder);
                    //sb.Append(' ');
                }

                return sb;

            }
            static object Decoder(int n = 2)
            {

                Console.WriteLine("what is the sentence you want to decode");

                string decode = Console.ReadLine();
                string decodersplit = " ";
                char[] therealthing = { ' ' };
                int masti = 0;
                int masti2 = 0;
                int masti3 = 0;
                int helper2 = 0;
                int helper = 0;
                char namaste = ' ';
                StringBuilder sb2 = new StringBuilder();
                for (int i = 0; i < decode.Length; i++)
                {
                    decodersplit = decode.Substring(helper, 3);
                    therealthing = decodersplit.ToCharArray();
                    masti = Converter2(therealthing[2]);
                    masti2 = therealthing[1];
                    masti3 = therealthing[3];
                    helper2 = masti * masti2 + masti3;
                    namaste = Converter(27 + i - helper2);
                    sb2.Append(namaste);
                    helper += 3;
                }
                return sb2;
            }
            static void Main(string[] args)
            {
            menu:
                Console.WriteLine("Hello! to encode- press 1, to decoded press 2");
                int response = int.Parse(Console.ReadLine());
                if (response == 1)
                {
                    Console.WriteLine(Encoder(response));
                    goto menu;
                }
                else if (response == 2)
                {
                    Console.WriteLine(Decoder(response));
                    goto menu;

                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
        }
    }
}