using System.Windows.Forms;
using System.Drawing;

public class StyledButton : Button
{
    public StyledButton()
    {
        this.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
        this.UseVisualStyleBackColor = true;
    }
}
