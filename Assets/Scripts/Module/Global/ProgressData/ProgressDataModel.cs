using Agate.MVC.Base;
using System.Collections.Generic;
using System;

namespace SpaceInvader.Module.ProgressData
{
    public class ProgressDataModel : BaseModel, IProgressDataModel
    {
        public Progress Progress { get; private set; }

        public void SetProgressData(Progress progress)
        {
            Progress = progress;
            SetDataAsDirty();
        }

        public void SetHighScore(int highScore, string name)
        {
            Progress.HighScore.Insert(0, new Tuple<int,string>(highScore, name) );
            SetDataAsDirty();
        }



        /*public void SetSelectedInsect(InsectData insect)
        {
            Progress.SelectedInsect = insect;
            SetDataAsDirty();
        }*/
    }
}