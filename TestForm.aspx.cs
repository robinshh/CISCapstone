using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Threading.Tasks;

namespace _484Class1
{
    [DebuggerDisplay("{parsed}")]
    public partial class TestForm : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String phrase = TextBox1.Text;
            J[] objectArr = new J[phrase.Split(' ').Length];
            bool phase = false;
            int pl = 0;
            foreach (var word in phrase.Split(' '))
            {
                if (phase)
                {
                    objectArr[pl] = new J(word, "Some Text");
                    pl++;
                    phase = !phase;
                }
                else
                {
                    pl++;
                    phase = !phase;
                }
            }
            TextBox1.Text = "";
        }



        public class J
        {
            private int num;
            private char let;
            public M nextletter;
            
            public J(String fullWord, String def)
            {
                this.num = fullWord.Length;
                this.let = fullWord[0]
;
                this.nextletter = new M(def);
                this.nextletter.parseWord(fullWord);

                
            }
            public int Num
            {
                get
                {
                    return this.num;
                }
                set
                {
                    if (value > -1)
                    {
                        this.num = value;
                    }
                    else
                    {
                        this.num = 0;
                    }
                }
            }
                public char Let
            {
                get
                {
                    return this.let;
                }
                set
                {
                    this.let = value;
                }
            }
            public override string ToString()
            {
                return "Num: " + this.Num+ ", First Letter: " + this.let;
            }
        }


        public class M
        {
            public char[] parsed { get; set; }
            public U fullDef;

            public M(String def)
            {
                this.fullDef = new U(def);
            }
            public void parseWord(String word)
            {
                this.parsed = new char[word.Length];
                for (int i = 0; i < word.Length; i++)
                {
                    
                    parsed[i] = word[i];
                    
                    
                }
                
            }
            public override string ToString()
            {
                {
                    return "length:" + parsed.Length;
                }
            }
            
        }


        public class U
        {
            public string def { get; set; }

            public U(String def)
            {
                this.def = def;
            }
            public override string ToString()
            {
                {
                    return "Def:" + this.def;
                }
            }
        }

        
    }
}