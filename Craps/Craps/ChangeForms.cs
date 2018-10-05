using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Craps
{
    public static class ChangeForms
    {
        public static void goToMenu(Form f)
        {
            Menu formMenuDialog = new Menu();
            formMenuDialog.Show();
            f.Close();
        }

        public static void goToNew(Form f)
        {
            NewPlayer np = new NewPlayer();
            np.Show();
            f.Hide();
        }

        public static void goToPlay(Form f)
        {
            Play p = new Play();
            p.Show();
            f.Hide();
        }

        public static void goToLoad(Form f)
        {
            LoadPlayer l = new LoadPlayer();
            l.Show();
            f.Hide();
        }

        public static void goToEditDel(Form f)
        {
            EditDeletePlayer e = new EditDeletePlayer();
            e.Show();
            f.Hide();
        }

        public static void goToEdit(Form f)
        {
            EditScreen e = new EditScreen();
            e.Show();
            f.Hide();
        }
    }
}
