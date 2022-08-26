using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets
{
    public static class Utils
    {
        public static string RetiraPontos(string texto)
        {
            string result = "";           
            for (int i = 0; i < texto.Length; i++)
            {
                if ((texto[i] != '.') && texto[i] != '-')
                    result += texto[i];
            }                            
            return result;
        }   
        public static string AplicaMascaraCpf(string texto)
        {
            string result = "";
            for (int i = 0; i < texto.Length; i++)
            {   
                if((i == 3) || (i == 6))
                    result += '.';
                else if(i == 9)
                    result += '-';                
                result += texto[i];
            }
            return result;
        }
        public static bool MessageYesNo(string msg, string titulo)
        {
            DialogResult dialogResult = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                return true;
            else
                return false;
        }
        public static void MessageInfo(string msg, string titulo)
        {
            MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void MessageErro(string msg, string titulo)
        {
            MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void MessageExclamation(string msg, string titulo)
        {
            MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
