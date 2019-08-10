using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLAME_TEST
{
    public partial class CASE2 : Form
    {
        public CASE2()
        {
            InitializeComponent();
        }

        private void CASE2_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void splitPointStringNumeric(string strNum, out string OAmount, out string OSatang)
        {
            string[] splitPoint = strNum.Split('.');
            OSatang = (splitPoint.Count() == 2) ? (splitPoint[1].Length > 2) ? splitPoint[1].Substring(0, 2) : splitPoint[1] : "00";
            OAmount = splitPoint != null ? splitPoint[0].Replace(",", "") : "0";

        }

        
        private string amountToText(string amount)
        {
            throw new NotImplementedException();
        }

        private string numToText(string satang)
        {
            string[] retText = new string[satang.Length];
            char[] arr = satang.ToCharArray();
            Array.Reverse(arr);
            satang = new string(arr);

            for (int a = 0; a < satang.Length; a++)
            {
                char charNum = satang[a];
                retText[a] = getNumText(charNum, a + 1, satang.Length == 1);
            }
            Array.Reverse(retText);
            string tt = "";

            for (int a2 = 0; a2 < retText.Length; a2++)
            {
                tt += retText[a2];
            }
            return tt;
        }

        private string getNumText(char charNum, int v, bool oneDigit)
        {
            string numText = "";
            string multipleText = "";
            string resultText = "";

            switch (charNum)
            {
                case '0':
                    {
                        if (oneDigit)
                        {
                            numText = "ศูนย์";
                        }

                        break;
                    }
                case '1':
                    {
                        if (!oneDigit && v == 1)
                            numText = "เอ็ด";
                        else if (v != 2)
                            numText = "หนึ่ง";

                        break;
                    }
                case '2':
                    {
                        if (v == 2)
                        {
                            numText = "ยี่";
                        }
                        else
                            numText = "สอง";
                        break;
                    }
                case '3':
                    {
                        numText = "สาม";
                        break;
                    }
                case '4':
                    {
                        numText = "สี่";
                        break;
                    }
                case '5':
                    {
                        numText = "ห้า";
                        break;
                    }
                case '6':
                    {
                        numText = "หก";
                        break;
                    }
                case '7':
                    {
                        numText = "เจ็ด";
                        break;
                    }
                case '8':
                    {
                        numText = "แปด";
                        break;
                    }
                case '9':
                    {
                        numText = "เก้า";
                        break;
                    }

            }
            switch (v)
            {
                case 1:
                    {

                        break;

                    }
                case 2:
                    {
                        if (charNum != '0')
                            multipleText = "สิบ";
                        break;

                    }
                case 3:
                    {
                        if (charNum != '0')
                            multipleText = "ร้อย";
                        break;

                    }
                case 4:
                    {
                        if (charNum != '0')
                            multipleText = "พัน";
                        break;

                    }
                case 5:
                    {
                        if (charNum != '0')
                            multipleText = "หมื่น";
                        break;

                    }
                case 6:
                    {
                        if (charNum != '0')
                            multipleText = "แสน";
                        break;

                    }
                case 7:
                    {
                        if (charNum != '0')
                            multipleText = "ล้าน";
                        break;

                    }
            }
            resultText = numText + multipleText;
            return resultText;
        }

        private string toSatang(decimal convert)
        {
            string input_decimal_number = convert.ToString("F"); 
            var regex = new System.Text.RegularExpressions.Regex("(?<=[\\.])[0-9]+");
            if (regex.IsMatch(input_decimal_number))
            {
                return regex.Match(input_decimal_number).Value;
            }
            return "00";
        }

        private void BtnConvertToText_Click(object sender, EventArgs e)
        {
            decimal convert = Convert.ToDecimal(txtInputNum.Text);
            string amount, satang;
            string textAmount, textSatang;
            amount = string.Format("{0}", (int)convert);
            satang = toSatang(convert);
            textSatang = !satang.Equals("00") ? numToText(satang) + "สตางค์" : "";
            textAmount = numToText(amount);

           lbResult.Text= textAmount + "บาท" + textSatang;
        }
    }
}
