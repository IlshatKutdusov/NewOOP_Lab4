using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOP_Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Part
        {
            public string PartName { get; set; }
            public int PartId { get; set; }
        }

        public static int redcolor = 0, greencolor = 0, bluecolor = 0;

        private int i = -1, k = -1, kcircle = -1, ktriangle = -1, krectangle = -1, kellipse = -1, kparallelogram = -1;

        private List<Part> list = new List<Part>();
        private List<Circle> circlelist = new List<Circle>();
        private List<Triangle> trianglelist = new List<Triangle>();
        private List<Rectangle> rectanglelist = new List<Rectangle>();
        private List<Ellipse> ellipselist = new List<Ellipse>();
        private List<Parallelogram> parallelogramlist = new List<Parallelogram>();

        private Circle circle;
        private Triangle triangle;
        private Rectangle rectangle;
        private Ellipse ellipse;
        private Parallelogram parallelogram;
        private Point t1, t2, t3;
        private Random randomint = new Random();

        private void UpDate()
        {
            pictureBox1.Image = null;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].PartName == "circle")
                {
                    circlelist[list[i].PartId].Show(pictureBox1);
                }
                else
                {
                    if (list[i].PartName == "triangle")
                    {
                        trianglelist[list[i].PartId].Show(pictureBox1);
                    }
                    else
                    {
                        if (list[i].PartName == "rectangle")
                        {
                            rectanglelist[list[i].PartId].Show(pictureBox1);
                        }
                        else
                        {
                            if(list[i].PartName == "ellipse")
                            {
                                ellipselist[list[i].PartId].Show(pictureBox1);
                            }
                            else
                            {
                                if (list[i].PartName == "parallelogram")
                                {
                                    parallelogramlist[list[i].PartId].Show(pictureBox1);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void EnableFunc()
        {
            if (button6.Enabled == false)
            {
                button6.Enabled = true;
                comboBox1.Enabled = true;
                button7.Enabled = true;
                comboBox2.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
            }
        }

        private void EnableFunc1()
        {
            if (button15.Enabled == false)
            {
                button15.Enabled = true;
                comboBox3.Enabled = true;
            }
        }

        private void ListAddCircle()
        {
            kcircle++;
            circlelist.Add(circle);
            list.Add(new Part() { PartName = "circle", PartId = kcircle });
            i++;
            comboBox1.Items.Add(i + ". Circle(" + kcircle + ") R=" + circle.redcolor + " G=" + circle.greencolor + " B=" + circle.bluecolor);
            comboBox1.SelectedIndex = i;
            comboBox2.Items.Add(i + ". Circle(" + kcircle + ")  R=" + circle.redcolor + " G=" + circle.greencolor + " B=" + circle.bluecolor);
            comboBox2.SelectedIndex = i;
        }

        private void ListAddTriangle()
        {
            ktriangle++;
            trianglelist.Add(triangle);
            list.Add(new Part() { PartName = "triangle", PartId = ktriangle });
            i++;
            comboBox1.Items.Add(i + ". Triangle(" + ktriangle + ") R=" + triangle.redcolor + " G=" + triangle.greencolor + " B=" + triangle.bluecolor);
            comboBox1.SelectedIndex = i;
            comboBox2.Items.Add(i + ". Triangle(" + ktriangle + ")  R=" + triangle.redcolor + " G=" + triangle.greencolor + " B=" + triangle.bluecolor);
            comboBox2.SelectedIndex = i;
        }

        private void ListAddRectangle()
        {
            krectangle++;
            rectanglelist.Add(rectangle);
            list.Add(new Part() { PartName = "rectangle", PartId = krectangle });
            i++;
            comboBox1.Items.Add(i + ". Rectangle(" + krectangle + ") R=" + rectangle.redcolor + " G=" + rectangle.greencolor + " B=" + rectangle.bluecolor);
            comboBox1.SelectedIndex = i;
            comboBox2.Items.Add(i + ". Rectangle(" + krectangle + ")  R=" + rectangle.redcolor + " G=" + rectangle.greencolor + " B=" + rectangle.bluecolor);
            comboBox2.SelectedIndex = i;
        }

        private void ListAddEllipse()
        {
            kellipse++;
            ellipselist.Add(ellipse);
            list.Add(new Part() { PartName = "ellipse", PartId = kellipse });
            i++;
            comboBox1.Items.Add(i + ". Ellipse(" + kellipse + ") R=" + ellipse.redcolor + " G=" + ellipse.greencolor + " B=" + ellipse.bluecolor);
            comboBox1.SelectedIndex = i;
            comboBox2.Items.Add(i + ". Ellipse(" + kellipse + ")  R=" + ellipse.redcolor + " G=" + ellipse.greencolor + " B=" + ellipse.bluecolor);
            comboBox2.SelectedIndex = i;
            comboBox3.Items.Add(kellipse + ". Ellipse(" + kellipse + ") R=" + ellipse.redcolor + " G=" + ellipse.greencolor + " B=" + ellipse.bluecolor);
            comboBox3.SelectedIndex = kellipse;
        }

        private void ListAddParallelogram()
        {
            kparallelogram++;
            parallelogramlist.Add(parallelogram);
            list.Add(new Part() { PartName = "parallelogram", PartId = kparallelogram });
            i++;
            comboBox1.Items.Add(i + ". Parallelogram(" + kparallelogram + ") R=" + parallelogram.redcolor + " G=" + parallelogram.greencolor + " B=" + parallelogram.bluecolor);
            comboBox1.SelectedIndex = i;
            comboBox2.Items.Add(i + ". Parallelogram(" + kparallelogram + ")  R=" + parallelogram.redcolor + " G=" + parallelogram.greencolor + " B=" + parallelogram.bluecolor);
            comboBox2.SelectedIndex = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circle = new Circle(Convert.ToInt16(numericUpDown3.Value), Convert.ToInt16(numericUpDown4.Value), Convert.ToInt16(numericUpDown5.Value), true, redcolor, greencolor, bluecolor);
            circle.Show(pictureBox1);
            ListAddCircle();
            EnableFunc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.X = Convert.ToInt16(numericUpDown6.Value);
            t1.Y = Convert.ToInt16(numericUpDown7.Value);
            t2.X = Convert.ToInt16(numericUpDown8.Value);
            t2.Y = Convert.ToInt16(numericUpDown9.Value);
            t3.X = Convert.ToInt16(numericUpDown10.Value);
            t3.Y = Convert.ToInt16(numericUpDown11.Value);

            triangle = new Triangle(1, 1, t1.X, t1.Y, t2.X, t2.Y, t3.X, t3.Y, true, redcolor, greencolor, bluecolor);
            triangle.Show(pictureBox1);
            ListAddTriangle();
            EnableFunc();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rectangle = new Rectangle(Convert.ToInt16(numericUpDown12.Value), Convert.ToInt16(numericUpDown13.Value), Convert.ToInt16(numericUpDown14.Value), Convert.ToInt16(numericUpDown15.Value), true, redcolor, greencolor, bluecolor);
            rectangle.Show(pictureBox1);
            ListAddRectangle();
            EnableFunc();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            k = comboBox3.SelectedIndex;
            ellipselist[k].Rotate();
            UpDate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 colorsel = new Form2(this);
            colorsel.ShowDialog();
            button5.BackColor = Color.FromArgb(redcolor, greencolor, bluecolor);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            k = comboBox1.SelectedIndex;

            if (list[k].PartName == "circle")
            {
                circlelist[list[k].PartId].MoveTo(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value));
            }
            else
            {
                if (list[k].PartName == "triangle")
                {
                    trianglelist[list[k].PartId].MoveTo(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value));
                }
                else
                {
                    if (list[k].PartName == "rectangle")
                    {
                        rectanglelist[list[k].PartId].MoveTo(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value));
                    }
                    else
                    {
                        if (list[k].PartName == "ellipse")
                        {
                            ellipselist[list[k].PartId].MoveTo(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value));
                        }
                        else
                        {
                            if (list[k].PartName == "parallelogram")
                            {
                                parallelogramlist[list[k].PartId].MoveTo(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value));
                            }
                        }
                    }
                }
            }
            UpDate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            k = comboBox2.SelectedIndex;

            if (list[k].PartName == "circle")
            {
                circlelist[list[k].PartId].Visibility();
            }
            else
            {
                if (list[k].PartName == "triangle")
                {
                    trianglelist[list[k].PartId].Visibility();
                }
                else
                {
                    if (list[k].PartName == "rectangle")
                    {
                        rectanglelist[list[k].PartId].Visibility();
                    }
                    else
                    {
                        if (list[k].PartName == "ellipse")
                        {
                            ellipselist[list[k].PartId].Visibility();
                        }
                        else
                        {
                            if (list[k].PartName == "parallelogram")
                            {
                                parallelogramlist[list[k].PartId].Visibility();
                            }
                        }
                    }
                }
            }
            UpDate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            circle = new Circle();
            circle.Show(pictureBox1);
            ListAddCircle();
            EnableFunc();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            triangle = new Triangle();
            triangle.Show(pictureBox1);
            ListAddTriangle();
            EnableFunc();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            rectangle = new Rectangle();
            rectangle.Show(pictureBox1);
            ListAddRectangle();
            EnableFunc();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ellipse = new Ellipse(Convert.ToInt16(numericUpDown16.Value), Convert.ToInt16(numericUpDown17.Value), Convert.ToInt16(numericUpDown18.Value), Convert.ToInt16(numericUpDown19.Value), true, redcolor, greencolor, bluecolor);
            ellipse.Show(pictureBox1);
            ListAddEllipse();
            EnableFunc();
            EnableFunc1();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ellipse = new Ellipse();
            ellipse.Show(pictureBox1);
            ListAddEllipse();
            EnableFunc();
            EnableFunc1();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            parallelogram = new Parallelogram(Convert.ToInt16(numericUpDown20.Value), Convert.ToInt16(numericUpDown21.Value), Convert.ToInt16(numericUpDown22.Value), Convert.ToInt16(numericUpDown23.Value), Convert.ToInt16(numericUpDown24.Value), true, redcolor, greencolor, bluecolor);
            parallelogram.Show(pictureBox1);
            ListAddParallelogram();
            EnableFunc();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            parallelogram = new Parallelogram();
            parallelogram.Show(pictureBox1);
            ListAddParallelogram();
            EnableFunc();
        }
    }
}
