using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlashCardsEngine.Core
{
    public class UnstricAnswer
    {
        public string[] PossibleAnswers(string strictAnswer)
        {
            string[] split = strictAnswer.Split(' ');
            List<string> matches = new List<string>();
            foreach (var i in split)
            {
                if(i.StartsWith("{") && i.EndsWith("}"))
                {
                    matches.Add(i.Trim('{', '}'));
                }
            }
            return matches.ToArray();
        }
        //
        public string StrippedAnswer(string answer)
        {
            return answer.Trim('{', '}');
        }
        //
    }
}
