using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ScoreLevel
    {
        public decimal UserScore { get; set; }
        public int UserLevel { get; set; }
        public string LevelName { get; set; }
        public int LevelScore { get; set; }
        public int NextLevelScore { get; set; }

    }
}
