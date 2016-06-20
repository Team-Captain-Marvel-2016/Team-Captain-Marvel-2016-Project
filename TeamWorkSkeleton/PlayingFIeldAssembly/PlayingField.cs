
namespace PlayingFIeldAssembly
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PlayingField
    {
        public PlayingField(int x, int y)
        {
            this.Field = new bool[x, y];
        }

        public bool[,] Field { get; set; }
    }
}
