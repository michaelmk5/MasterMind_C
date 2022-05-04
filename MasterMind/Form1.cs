namespace MasterMind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreaSoluzione();
        }
        int[] soluzione = new int[4];
        int[] codice= { 0, 0, 0, 0 };
        int vite = 10, pos = 0, col  = 0;

        Color[] colori = {Color.White, Color.Black, Color.Red, Color.Green, Color.Blue};
        int a = 1, b=1, c=1, d=1;
        Random rand = new Random();
        private void CreaSoluzione()
        {
            for(int i = 0; i < soluzione.Length; i++)
            {
                soluzione[i] = rand.Next(0,4);
            }
            vite_r.Text = "" + vite;
        }
        
        private void btn1_Click(object sender, EventArgs e)
        {
            if (a == 5)
            {
                a = 1;
            }
            btn1.BackColor = colori[a];
            codice[0] = a;
            a++;
            Console.WriteLine(codice[0]);
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            if (b == 5)
            {
                b = 1;
            }
            btn2.BackColor = colori[b];
            codice[1] = b;
            b++;
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            if (c == 5)
            {
                c = 1;
            }
            btn3.BackColor = colori[c];
            codice[2] = c;
            c++;
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if (d == 5)
            {
                d = 1;
            }
            btn4.BackColor = colori[d];
            codice[3] = d;
            d++;
        }

        private void btnverifica_Click(object sender, EventArgs e)
        {
            pos = 0;
            col = 0;
            int[] tmp_soluzione = new int[4];
            for (int i = 0; i < 4; i++)
            {
                if (codice[i] == 0)
                {
                    lb_error.Visible = true;
                    return;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if(codice[i] == soluzione[i])
                {
                    pos++;
                }
                tmp_soluzione[i] = soluzione[i];
            }
            pos_cor.Text = "" + pos;
            
            for (int i = 0; i < 4; i++)
            {
                for(int j=0; j < 4; j++)
                {
                    if (tmp_soluzione[j] == codice[i])
                    {
                        col++;
                        tmp_soluzione[j] = 100;
                        break;                   
                    }
                }
            }
            col_cor.Text = "" + col;
            vite--;
            vite_r.Text = "" + vite;
            lb_error.Visible = false;
            if(pos == 4)
            {
                lb_ris.Text = "HAI VINTO!";
                lb_ris.Visible = true;
                lb_pos.Visible = false;
                lb_col.Visible = false;
                pos_cor.Visible = false;
                col_cor.Visible = false;
                lb_vite.Visible = false;
                vite_r.Visible = false;
                btn_reset.Visible = true;
                btnverifica.Visible = false;

            }
            else if(vite == 0)
            {
                lb_ris.Text = "HAI PERSO!";
                lb_ris.Visible = true;
                lb_pos.Visible = false;
                lb_col.Visible = false;
                pos_cor.Visible = false;
                lb_vite.Visible = false;
                vite_r.Visible = false;
                col_cor.Visible = false;
                btn_reset.Visible = true;
                btnverifica.Visible = false;
            }
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            lb_ris.Visible = false;
            lb_pos.Visible = true;
            lb_col.Visible = true;
            pos_cor.Visible = true;
            lb_vite.Visible = true;
            vite_r.Visible = true;
            col_cor.Visible = true;
            btn_reset.Visible = false;
            btnverifica.Visible = true;
            vite = 10;
            pos = 0;
            col = 0;
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            pos_cor.Text = "" + pos;
            col_cor.Text = "" + col;
            vite_r.Text = "" + vite;
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            CreaSoluzione();
        }
    }
}