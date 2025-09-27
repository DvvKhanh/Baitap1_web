using System;
using System.Text;
using SnakeLib;

public partial class api : System.Web.UI.Page
{
    private static SnakeGame game = new SnakeGame(20, 20);

    protected void Page_Load(object sender, EventArgs e)
    {
        string reset = Request.QueryString["reset"];
        string dir = Request.QueryString["dir"];

        if (!string.IsNullOrEmpty(reset) && reset == "true")
        {
            game.ResetGame(); // reset lại game
        }
        else
        {
            if (!string.IsNullOrEmpty(dir) && !game.IsGameOver)
            {
                try
                {
                    Direction newDir = (Direction)Enum.Parse(typeof(Direction), dir, true);

                    // không cho quay ngược 180 độ
                    if (!IsOpposite(game.Dir, newDir))
                        game.Dir = newDir;

                    game.Update();
                }
                catch
                {
                    // bỏ qua input sai
                }
            }
        }

        // Xuất JSON
        StringBuilder sb = new StringBuilder();
        sb.Append("{");

        // Snake
        sb.Append("\"Snake\":[");
        for (int i = 0; i < game.Snake.Count; i++)
        {
            System.Drawing.Point p = game.Snake[i];
            sb.Append("{\"X\":" + p.X + ",\"Y\":" + p.Y + "}");
            if (i < game.Snake.Count - 1) sb.Append(",");
        }
        sb.Append("],");

        // Food
        sb.Append("\"Food\":{\"X\":" + game.Food.X + ",\"Y\":" + game.Food.Y + "},");

        // GameOver
        sb.Append("\"IsGameOver\":" + (game.IsGameOver ? "true" : "false"));

        sb.Append("}");

        Response.ContentType = "application/json";
        Response.Write(sb.ToString());
    }

    private bool IsOpposite(Direction d1, Direction d2)
    {
        return (d1 == Direction.Left && d2 == Direction.Right) ||
               (d1 == Direction.Right && d2 == Direction.Left) ||
               (d1 == Direction.Up && d2 == Direction.Down) ||
               (d1 == Direction.Down && d2 == Direction.Up);
    }
}
