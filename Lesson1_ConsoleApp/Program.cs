using System;
using System.Drawing;
using System.Windows.Forms;


Form form = new();
form.Text = "My first app";


// Application.Run(new Form());


form.MouseClick += Form_MouseClick;



// EventArgs
// EventHandler


void Form_MouseClick(object? sender, MouseEventArgs e)
{
    form.BackColor = Color.DeepSkyBlue;
    Console.WriteLine(e.X);
    Console.WriteLine(e.Y);
}



// form.Show();
form.ShowDialog();