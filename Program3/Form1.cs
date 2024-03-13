//Program 3
//CIS 199-03
//DUE: 4.3.2022
//Grading ID: S2223
//The purpose of this program is to accept the imput of the user via a form. The user
//will choose a flower, a garden type, and a quanity and the cost will be calculated.
using System;
using static System.Console;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e) //calculate button
        {
            //declare variables
            string GARDEN; //type of garden
            double FLOWER;  //flower number
            double FLOWER_RATE; //rate based on flower type
            double GARDEN_RATE;  //rate based on garden type
            double QUANTITY;  //number of flowers
            double QUANTITY_RATE;  //discount rate based on number of flowers
            double TOTAL_DISCOUNT; //Total discount to be taken off 
            double FLOWERS_COST; //flowers cost before discount
            double BASE_COST; //Base cost before discount
            double COST;  //total cost

            string.TryParse(gardenTxBx, out GARDEN); //read user input for garden typr and 
            //assign variable

            {
                if (GARDEN == "Preimum") ;  //assign garden rate based on garden type
                {
                    GARDEN_RATE = 1.1;
                }
                if (GARDEN == "Standard") ;
                {
                    GARDEN_RATE = 1.0;
                }
                if (GARDEN == "Discount") ;
                {
                    GARDEN_RATE = 0.9;
                }

            }

            double.TryParse(flowerNumTbx, out FLOWER);  //read user inmput for flower type

            {
                if (FLOWER == 10001) ;  //assign flower rate based on flower type
                {
                    FLOWER_RATE = 7.87;
                }
                if (FLOWER == 10002) ;
                {
                    FLOWER_RATE = 9.51;
                }
                if (FLOWER == 10003) ;
                {
                    FLOWER_RATE = 10.73;
                }
                if (FLOWER == 10004) ;
                {
                    FLOWER_RATE = 9.99;
                }
                if (FLOWER == 10005) ;
                {
                    FLOWER_RATE = 11.99;
                }
                if (FLOWER == 10006) ;
                {
                    FLOWER_RATE = 5.00;
                }
                if (FLOWER == 10007) ;
                {
                    FLOWER_RATE = 4.58;
                }
            }

            double.TryParse(quantityTbx, out QUANTITY);  //read user input for quantity of flowers

            {
                if (QUANTITY == 0 || QUANTITY == 1 || QUANTITY == 2 || QUANTITY == 3 || QUANTITY == 4
                    || QUANTITY == 5) ;
                {
                    QUANTITY_RATE = 1.0;
                }
                if (QUANTITY >= 6 && QUANTITY <= 15) ;
                {
                    QUANTITY_RATE = 0.95;
                }
                if (QUANTITY >= 16 && QUANTITY <= 20) ;
                {
                    QUANTITY_RATE = 0.9;
                }
                if (QUANTITY >= 21) ;
                {
                    QUANTITY_RATE = 0.85;
                }
            }

            FLOWERS_COST=QUANTITY* FLOWER_RATE;  // calculate flowers cost
            FLOWERS_COST = flowersCostTbx;  //assign flower cost to appropriate text box

            BASE_COST = (FLOWERS_COST * FLOWER_RATE) * GARDEN_RATE; //calculate base cost
            BASE_COST = baseCostTbx;  //assign base cost to appropriate text box

            TOTAL_DISCOUNT = discountPercentTbx;  //assign discount to appropriate text box

            BASE_COST* TOTAL_DISCOUNT = COST;  //calculate total cost
            COST = finalCostTbx;  //assign cost to appropriate textbox

















        }
    }
}
