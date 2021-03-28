using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek5
{
    public class MorseTree
    {
        #region given code
        private char character;
        private MorseTree dot;
        private MorseTree dash;

        public MorseTree AddCharacter(char c, string morsecode)
        {
            c = Char.ToLower(c);
            if (morsecode == "")
                character = c;
            else if (morsecode[0] == '.')
            {
                if (dot == null)
                    dot = new MorseTree();
                dot.AddCharacter(c, morsecode.Remove(0, 1));
            }
            else
            {
                if (dash == null)
                    dash = new MorseTree();
                dash.AddCharacter(c, morsecode.Remove(0, 1));
            }

            return this;
        }
        #endregion

        /// <summary>
        /// Returns char from tree based on given morsecode
        /// </summary>
        /// <param name="morsecode">morsecode string</param>
        /// <returns>returns character that belongs to morsecode, if none found returns ?</returns>
        public char GiveCharacterByMorseCode(string morsecode)
        {
            if(morsecode.Length == 0)
                return character;
            if (morsecode.First() == '.' && dot != null)
                return dot.GiveCharacterByMorseCode(morsecode.Remove(0,1));
            if (morsecode.First() == '-' && dash != null)
                return dash.GiveCharacterByMorseCode(morsecode.Remove(0,1));

            return '?';
        }

        /// <summary>
        /// Checks which character belongs by calling GiveMorsecode
        /// </summary>
        /// <param name="c">char</param>
        /// <returns></returns>
        public string GiveMorsecode(char c)
        {
            return GiveMorsecode(Char.ToLower(c), "");
        }

        /// <summary>
        /// Checks which morsecode the char belongs to
        /// </summary>
        /// <param name="c">character</param>
        /// <param name="code">morsecode</param>
        /// <returns>morsecode string</returns>
        private string GiveMorsecode(char c, string code)
        {
            if (c == character)
                return code;
            if (dot == null && dash == null)
                return string.Empty;
            string result = string.Empty;
            if (dot != null)
                result = dot.GiveMorsecode(c, code + '.');

            if (dash != null)
                result += dash.GiveMorsecode(c, code + '-');

            return result;
        }
    }
}
