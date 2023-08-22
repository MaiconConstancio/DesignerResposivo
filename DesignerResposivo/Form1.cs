namespace DesignerResposivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void renderizaInterface()
        {
            int tamanhoColuna = 300/2;
            int tamanhoColunaSuperior = 200/2;

            // WindowState = FormWindowState.Minimized; //qual o estado da janela == deixa em minimizado logo de cara, se eu n falar pra quem é o form, ele sempre vai pro forme 1
            //codigo de cima funciona se tirar as //
            
            WindowState = FormWindowState.Maximized; //qual o estado da janela == deixa em FullScreen, se eu n falar pra quem é o form, ele sempre vai pro forme 1


            //Jogar o painel no meio da tela

            //ClientSize.Width / 2 == tamanho do monitor da pessoa no meio
            // - panel.Size.Width que vai depois, é a metade do painel que o eixo foca sempre no superior esquerdo
            //ClientSize.Height / 2 == tamanho do monitor da pessoa no meio
            // - panel.Size.Height que vai depois, é a metade do painel que o eixo foca sempre no superior esquerdo

            menuEsquerdo.Location = new Point(0, 0); //Para começar sempre no canto da tela localizacao 0,0
            menuEsquerdo.Size = new Size(tamanhoColuna, ClientSize.Height);
            panel.Location = new Point((ClientSize.Width / 2 - panel.Size.Width / 2) + tamanhoColuna +  (ClientSize.Height / 2 - panel.Size.Height / 2)); //ClientSize é o tamanho da tela da PESSOA //Width é a largura
            //SUPERIOR

            menuSuperior.Location = new Point(tamanhoColuna, 0); //Para começar sempre no canto da tela localizacao 0,0
            menuSuperior.Size = new Size(ClientSize.Width, tamanhoColunaSuperior);
            panel.Location = new Point((ClientSize.Width / 2 - panel.Size.Width / 2) + tamanhoColunaSuperior + (ClientSize.Height / 2 - panel.Size.Height / 2)); //ClientSize é o tamanho da tela da PESSOA //Width é a largura

            




        }


        private void Form1_Load(object sender, EventArgs e)
        {
            renderizaInterface();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}