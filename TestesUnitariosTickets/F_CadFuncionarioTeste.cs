using System.Windows.Forms;
using Tickets.Views;
using Xunit;

namespace TestesUnitariosTickets
{
    public class F_CadFuncionarioTeste: Form
    {
        [Fact]
        public void TestValidaCampos()
        {
            //Incluindo
            F_CadFuncionario f_CadFuncionario = new F_CadFuncionario(false);
            f_CadFuncionario.txtNome.Text = "Teste";
            f_CadFuncionario.txtCpf.Text = "   .   .   -";
            bool result = f_CadFuncionario.ValidaCampos();
            //Esperado que seja false
            Assert.False(result);
        }
    }
}
