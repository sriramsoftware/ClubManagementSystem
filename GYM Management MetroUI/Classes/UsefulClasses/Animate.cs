using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static ClubManagement.Classes.Enums.Other;

namespace ClubManagement.Classes.UsefulClasses
{

    /// <summary>
    /// Animate class used to mange moving effects on controls ex: for ads 
    /// Under Constructing...
    /// </summary>
    /// 
    class Animate
    {

        private Control outerCtrl,innerCtrl;
        private Form frmContainer;
        private Point pOut, pIn;
        private Dir startDir, endDir;
        private DirStyle style;

        /// <summary>
        /// onOpen && onClose adsForms fire
        /// </summary>
        /// <param name="o">Outside control</param>
        /// <param name="i">Inside control</param>
        /// <param name="dirStart">Start moving direction for control</param>
        /// <param name="dirEnd">End moving direction for control</param>
        public Animate(Control o, Control i, Dir startDir, Dir endDir)
        {
            outerCtrl = o;
            innerCtrl = i;
            this.startDir = startDir;
            this.endDir = endDir;
            frmContainer = o.FindForm();
            if (startDir == Dir.RIGHT || startDir == Dir.LEFT) style = DirStyle.HORIZONTAL;
            else style = DirStyle.VERTICAL;
            getCtrlsPos();
            onWhat();
        }


       

        /// <summary>
        /// get inner and outter controls positions
        /// </summary>
        public void getCtrlsPos()
        {
            Point innerLocation = innerCtrl.FindForm().PointToClient(innerCtrl.Parent.PointToScreen(innerCtrl.Location));
            Point outterLocation = outerCtrl.FindForm().PointToClient(outerCtrl.Parent.PointToScreen(outerCtrl.Location));
            pIn = innerLocation;
            pOut = outterLocation;
        }


        /// <summary>
        /// moving procces
        /// notes: 
        ///     * handle groupPnl as In || Out
        ///     * thread
        ///     * confirm frm ~ closing
        ///     * reducing tm
        /// 
        /// </summary>
        public void onWhat()
        {
            

            // will handel if container form appear or not [ frmUserLogin , frmLoginUserAction ]

            string frmName = frmContainer.Name; // ex:frmLoginUserAction

            if (Application.OpenForms[frmName] != null)
            {
                //onOpen

                    using (Timer movingTimer = new Timer())
                    {
                        //setupTimer
                        movingTimer.Interval = 100;
                        //...
                        //...


                        //start

                    }

            }
            else{
                // onClose Form actions
                memoMe();
            }


        }
        

        public void memoMe()
        {

            //mome to prevent reCalcs again
           

        }





    }
}
