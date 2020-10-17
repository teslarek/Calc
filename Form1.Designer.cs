namespace Kalkulator
{
	partial class Form1
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox_wynik = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_l2 = new System.Windows.Forms.TextBox();
			this.textBox_l1 = new System.Windows.Forms.TextBox();
			this.radioButton_liczba2 = new System.Windows.Forms.RadioButton();
			this.radioButton_liczba1 = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton_add = new System.Windows.Forms.RadioButton();
			this.radioButton_sub = new System.Windows.Forms.RadioButton();
			this.radioButton_mul = new System.Windows.Forms.RadioButton();
			this.radioButton_div = new System.Windows.Forms.RadioButton();
			this.radioButton_mod = new System.Windows.Forms.RadioButton();
			this.radioButton_sqr = new System.Windows.Forms.RadioButton();
			this.radioButton_sqrt = new System.Windows.Forms.RadioButton();
			this.radioButton_cos = new System.Windows.Forms.RadioButton();
			this.radioButton_sin = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.b_dot = new System.Windows.Forms.Button();
			this.b_ent = new System.Windows.Forms.Button();
			this.b_3 = new System.Windows.Forms.Button();
			this.b_2 = new System.Windows.Forms.Button();
			this.b_add = new System.Windows.Forms.Button();
			this.b_6 = new System.Windows.Forms.Button();
			this.b_5 = new System.Windows.Forms.Button();
			this.b_9 = new System.Windows.Forms.Button();
			this.b_8 = new System.Windows.Forms.Button();
			this.b_sub = new System.Windows.Forms.Button();
			this.b_mul = new System.Windows.Forms.Button();
			this.b_div = new System.Windows.Forms.Button();
			this.b_sqr = new System.Windows.Forms.Button();
			this.b_sqrt = new System.Windows.Forms.Button();
			this.b_cos = new System.Windows.Forms.Button();
			this.b_0 = new System.Windows.Forms.Button();
			this.b_1 = new System.Windows.Forms.Button();
			this.b_4 = new System.Windows.Forms.Button();
			this.b_7 = new System.Windows.Forms.Button();
			this.b_mod = new System.Windows.Forms.Button();
			this.b_sin = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.Historia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.b_clear = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.quit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setDefault_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox_wynik);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox_l2);
			this.groupBox1.Controls.Add(this.textBox_l1);
			this.groupBox1.Controls.Add(this.radioButton_liczba2);
			this.groupBox1.Controls.Add(this.radioButton_liczba1);
			this.groupBox1.Location = new System.Drawing.Point(12, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dane i wynik";
			// 
			// textBox_wynik
			// 
			this.textBox_wynik.Location = new System.Drawing.Point(79, 69);
			this.textBox_wynik.Name = "textBox_wynik";
			this.textBox_wynik.Size = new System.Drawing.Size(100, 20);
			this.textBox_wynik.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "wynik";
			// 
			// textBox_l2
			// 
			this.textBox_l2.Location = new System.Drawing.Point(79, 39);
			this.textBox_l2.Name = "textBox_l2";
			this.textBox_l2.Size = new System.Drawing.Size(100, 20);
			this.textBox_l2.TabIndex = 3;
			// 
			// textBox_l1
			// 
			this.textBox_l1.Location = new System.Drawing.Point(79, 16);
			this.textBox_l1.Name = "textBox_l1";
			this.textBox_l1.Size = new System.Drawing.Size(100, 20);
			this.textBox_l1.TabIndex = 2;
			// 
			// radioButton_liczba2
			// 
			this.radioButton_liczba2.AutoSize = true;
			this.radioButton_liczba2.Location = new System.Drawing.Point(3, 39);
			this.radioButton_liczba2.Name = "radioButton_liczba2";
			this.radioButton_liczba2.Size = new System.Drawing.Size(58, 17);
			this.radioButton_liczba2.TabIndex = 1;
			this.radioButton_liczba2.Text = "liczba2";
			this.radioButton_liczba2.UseVisualStyleBackColor = true;
			// 
			// radioButton_liczba1
			// 
			this.radioButton_liczba1.AutoSize = true;
			this.radioButton_liczba1.Checked = true;
			this.radioButton_liczba1.Location = new System.Drawing.Point(3, 16);
			this.radioButton_liczba1.Name = "radioButton_liczba1";
			this.radioButton_liczba1.Size = new System.Drawing.Size(58, 17);
			this.radioButton_liczba1.TabIndex = 0;
			this.radioButton_liczba1.TabStop = true;
			this.radioButton_liczba1.Text = "liczba1";
			this.radioButton_liczba1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButton_add);
			this.groupBox2.Controls.Add(this.radioButton_sub);
			this.groupBox2.Controls.Add(this.radioButton_mul);
			this.groupBox2.Controls.Add(this.radioButton_div);
			this.groupBox2.Controls.Add(this.radioButton_mod);
			this.groupBox2.Controls.Add(this.radioButton_sqr);
			this.groupBox2.Controls.Add(this.radioButton_sqrt);
			this.groupBox2.Controls.Add(this.radioButton_cos);
			this.groupBox2.Controls.Add(this.radioButton_sin);
			this.groupBox2.Location = new System.Drawing.Point(15, 156);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 117);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Działania";
			// 
			// radioButton_add
			// 
			this.radioButton_add.AutoSize = true;
			this.radioButton_add.Location = new System.Drawing.Point(131, 20);
			this.radioButton_add.Name = "radioButton_add";
			this.radioButton_add.Size = new System.Drawing.Size(43, 17);
			this.radioButton_add.TabIndex = 8;
			this.radioButton_add.TabStop = true;
			this.radioButton_add.Text = "add";
			this.radioButton_add.UseVisualStyleBackColor = true;
			// 
			// radioButton_sub
			// 
			this.radioButton_sub.AutoSize = true;
			this.radioButton_sub.Location = new System.Drawing.Point(64, 89);
			this.radioButton_sub.Name = "radioButton_sub";
			this.radioButton_sub.Size = new System.Drawing.Size(42, 17);
			this.radioButton_sub.TabIndex = 7;
			this.radioButton_sub.TabStop = true;
			this.radioButton_sub.Text = "sub";
			this.radioButton_sub.UseVisualStyleBackColor = true;
			// 
			// radioButton_mul
			// 
			this.radioButton_mul.AutoSize = true;
			this.radioButton_mul.Location = new System.Drawing.Point(64, 66);
			this.radioButton_mul.Name = "radioButton_mul";
			this.radioButton_mul.Size = new System.Drawing.Size(41, 17);
			this.radioButton_mul.TabIndex = 6;
			this.radioButton_mul.TabStop = true;
			this.radioButton_mul.Text = "mul";
			this.radioButton_mul.UseVisualStyleBackColor = true;
			// 
			// radioButton_div
			// 
			this.radioButton_div.AutoSize = true;
			this.radioButton_div.Location = new System.Drawing.Point(64, 43);
			this.radioButton_div.Name = "radioButton_div";
			this.radioButton_div.Size = new System.Drawing.Size(39, 17);
			this.radioButton_div.TabIndex = 5;
			this.radioButton_div.TabStop = true;
			this.radioButton_div.Text = "div";
			this.radioButton_div.UseVisualStyleBackColor = true;
			// 
			// radioButton_mod
			// 
			this.radioButton_mod.AutoSize = true;
			this.radioButton_mod.Location = new System.Drawing.Point(64, 19);
			this.radioButton_mod.Name = "radioButton_mod";
			this.radioButton_mod.Size = new System.Drawing.Size(45, 17);
			this.radioButton_mod.TabIndex = 4;
			this.radioButton_mod.TabStop = true;
			this.radioButton_mod.Text = "mod";
			this.radioButton_mod.UseVisualStyleBackColor = true;
			// 
			// radioButton_sqr
			// 
			this.radioButton_sqr.AutoSize = true;
			this.radioButton_sqr.Location = new System.Drawing.Point(7, 89);
			this.radioButton_sqr.Name = "radioButton_sqr";
			this.radioButton_sqr.Size = new System.Drawing.Size(39, 17);
			this.radioButton_sqr.TabIndex = 3;
			this.radioButton_sqr.TabStop = true;
			this.radioButton_sqr.Text = "sqr";
			this.radioButton_sqr.UseVisualStyleBackColor = true;
			// 
			// radioButton_sqrt
			// 
			this.radioButton_sqrt.AutoSize = true;
			this.radioButton_sqrt.Location = new System.Drawing.Point(7, 66);
			this.radioButton_sqrt.Name = "radioButton_sqrt";
			this.radioButton_sqrt.Size = new System.Drawing.Size(42, 17);
			this.radioButton_sqrt.TabIndex = 2;
			this.radioButton_sqrt.TabStop = true;
			this.radioButton_sqrt.Text = "sqrt";
			this.radioButton_sqrt.UseVisualStyleBackColor = true;
			// 
			// radioButton_cos
			// 
			this.radioButton_cos.AutoSize = true;
			this.radioButton_cos.Location = new System.Drawing.Point(7, 43);
			this.radioButton_cos.Name = "radioButton_cos";
			this.radioButton_cos.Size = new System.Drawing.Size(42, 17);
			this.radioButton_cos.TabIndex = 1;
			this.radioButton_cos.TabStop = true;
			this.radioButton_cos.Text = "cos";
			this.radioButton_cos.UseVisualStyleBackColor = true;
			// 
			// radioButton_sin
			// 
			this.radioButton_sin.AutoSize = true;
			this.radioButton_sin.Location = new System.Drawing.Point(7, 20);
			this.radioButton_sin.Name = "radioButton_sin";
			this.radioButton_sin.Size = new System.Drawing.Size(38, 17);
			this.radioButton_sin.TabIndex = 0;
			this.radioButton_sin.TabStop = true;
			this.radioButton_sin.Text = "sin";
			this.radioButton_sin.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.b_dot);
			this.groupBox3.Controls.Add(this.b_ent);
			this.groupBox3.Controls.Add(this.b_3);
			this.groupBox3.Controls.Add(this.b_2);
			this.groupBox3.Controls.Add(this.b_add);
			this.groupBox3.Controls.Add(this.b_6);
			this.groupBox3.Controls.Add(this.b_5);
			this.groupBox3.Controls.Add(this.b_9);
			this.groupBox3.Controls.Add(this.b_8);
			this.groupBox3.Controls.Add(this.b_sub);
			this.groupBox3.Controls.Add(this.b_mul);
			this.groupBox3.Controls.Add(this.b_div);
			this.groupBox3.Controls.Add(this.b_sqr);
			this.groupBox3.Controls.Add(this.b_sqrt);
			this.groupBox3.Controls.Add(this.b_cos);
			this.groupBox3.Controls.Add(this.b_0);
			this.groupBox3.Controls.Add(this.b_1);
			this.groupBox3.Controls.Add(this.b_4);
			this.groupBox3.Controls.Add(this.b_7);
			this.groupBox3.Controls.Add(this.b_mod);
			this.groupBox3.Controls.Add(this.b_sin);
			this.groupBox3.Location = new System.Drawing.Point(22, 291);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 269);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Klawiatura";
			// 
			// b_dot
			// 
			this.b_dot.Location = new System.Drawing.Point(100, 224);
			this.b_dot.Name = "b_dot";
			this.b_dot.Size = new System.Drawing.Size(41, 35);
			this.b_dot.TabIndex = 24;
			this.b_dot.Text = ".";
			this.b_dot.UseVisualStyleBackColor = true;
			this.b_dot.Click += new System.EventHandler(this.b_dot_Click);
			// 
			// b_ent
			// 
			this.b_ent.Location = new System.Drawing.Point(149, 183);
			this.b_ent.Name = "b_ent";
			this.b_ent.Size = new System.Drawing.Size(41, 76);
			this.b_ent.TabIndex = 23;
			this.b_ent.Text = "ent";
			this.b_ent.UseVisualStyleBackColor = true;
			this.b_ent.Click += new System.EventHandler(this.b_ent_Click);
			// 
			// b_3
			// 
			this.b_3.Location = new System.Drawing.Point(100, 183);
			this.b_3.Name = "b_3";
			this.b_3.Size = new System.Drawing.Size(41, 35);
			this.b_3.TabIndex = 22;
			this.b_3.Text = "3";
			this.b_3.UseVisualStyleBackColor = true;
			this.b_3.Click += new System.EventHandler(this.b_3_Click);
			// 
			// b_2
			// 
			this.b_2.Location = new System.Drawing.Point(53, 183);
			this.b_2.Name = "b_2";
			this.b_2.Size = new System.Drawing.Size(41, 35);
			this.b_2.TabIndex = 21;
			this.b_2.Text = "2";
			this.b_2.UseVisualStyleBackColor = true;
			this.b_2.Click += new System.EventHandler(this.b_2_Click);
			// 
			// b_add
			// 
			this.b_add.Location = new System.Drawing.Point(149, 101);
			this.b_add.Name = "b_add";
			this.b_add.Size = new System.Drawing.Size(41, 76);
			this.b_add.TabIndex = 20;
			this.b_add.Text = "+";
			this.b_add.UseVisualStyleBackColor = true;
			this.b_add.Click += new System.EventHandler(this.b_add_Click);
			// 
			// b_6
			// 
			this.b_6.Location = new System.Drawing.Point(100, 142);
			this.b_6.Name = "b_6";
			this.b_6.Size = new System.Drawing.Size(41, 35);
			this.b_6.TabIndex = 19;
			this.b_6.Text = "6";
			this.b_6.UseVisualStyleBackColor = true;
			this.b_6.Click += new System.EventHandler(this.b_6_Click);
			// 
			// b_5
			// 
			this.b_5.Location = new System.Drawing.Point(53, 142);
			this.b_5.Name = "b_5";
			this.b_5.Size = new System.Drawing.Size(41, 35);
			this.b_5.TabIndex = 18;
			this.b_5.Text = "5";
			this.b_5.UseVisualStyleBackColor = true;
			this.b_5.Click += new System.EventHandler(this.b_5_Click);
			// 
			// b_9
			// 
			this.b_9.Location = new System.Drawing.Point(100, 101);
			this.b_9.Name = "b_9";
			this.b_9.Size = new System.Drawing.Size(41, 35);
			this.b_9.TabIndex = 17;
			this.b_9.Text = "9";
			this.b_9.UseVisualStyleBackColor = true;
			this.b_9.Click += new System.EventHandler(this.b_9_Click);
			// 
			// b_8
			// 
			this.b_8.Location = new System.Drawing.Point(53, 101);
			this.b_8.Name = "b_8";
			this.b_8.Size = new System.Drawing.Size(41, 35);
			this.b_8.TabIndex = 16;
			this.b_8.Text = "8";
			this.b_8.UseVisualStyleBackColor = true;
			this.b_8.Click += new System.EventHandler(this.b_8_Click);
			// 
			// b_sub
			// 
			this.b_sub.Location = new System.Drawing.Point(149, 60);
			this.b_sub.Name = "b_sub";
			this.b_sub.Size = new System.Drawing.Size(41, 35);
			this.b_sub.TabIndex = 15;
			this.b_sub.Text = "-";
			this.b_sub.UseVisualStyleBackColor = true;
			this.b_sub.Click += new System.EventHandler(this.b_sub_Click);
			// 
			// b_mul
			// 
			this.b_mul.Location = new System.Drawing.Point(100, 60);
			this.b_mul.Name = "b_mul";
			this.b_mul.Size = new System.Drawing.Size(41, 35);
			this.b_mul.TabIndex = 14;
			this.b_mul.Text = "*";
			this.b_mul.UseVisualStyleBackColor = true;
			this.b_mul.Click += new System.EventHandler(this.b_mul_Click);
			// 
			// b_div
			// 
			this.b_div.Location = new System.Drawing.Point(53, 60);
			this.b_div.Name = "b_div";
			this.b_div.Size = new System.Drawing.Size(41, 35);
			this.b_div.TabIndex = 13;
			this.b_div.Text = "/";
			this.b_div.UseVisualStyleBackColor = true;
			this.b_div.Click += new System.EventHandler(this.b_div_Click);
			// 
			// b_sqr
			// 
			this.b_sqr.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.b_sqr.Location = new System.Drawing.Point(149, 19);
			this.b_sqr.Name = "b_sqr";
			this.b_sqr.Size = new System.Drawing.Size(41, 35);
			this.b_sqr.TabIndex = 12;
			this.b_sqr.Text = "sqr";
			this.b_sqr.UseVisualStyleBackColor = true;
			this.b_sqr.Click += new System.EventHandler(this.b_sqr_Click);
			// 
			// b_sqrt
			// 
			this.b_sqrt.ForeColor = System.Drawing.Color.Red;
			this.b_sqrt.Location = new System.Drawing.Point(100, 19);
			this.b_sqrt.Name = "b_sqrt";
			this.b_sqrt.Size = new System.Drawing.Size(41, 35);
			this.b_sqrt.TabIndex = 11;
			this.b_sqrt.Text = "sqrt";
			this.b_sqrt.UseVisualStyleBackColor = true;
			this.b_sqrt.Click += new System.EventHandler(this.b_sqrt_Click);
			// 
			// b_cos
			// 
			this.b_cos.Location = new System.Drawing.Point(53, 19);
			this.b_cos.Name = "b_cos";
			this.b_cos.Size = new System.Drawing.Size(41, 35);
			this.b_cos.TabIndex = 10;
			this.b_cos.Text = "cos";
			this.b_cos.UseVisualStyleBackColor = true;
			this.b_cos.Click += new System.EventHandler(this.b_cos_Click);
			// 
			// b_0
			// 
			this.b_0.Location = new System.Drawing.Point(6, 224);
			this.b_0.Name = "b_0";
			this.b_0.Size = new System.Drawing.Size(88, 35);
			this.b_0.TabIndex = 9;
			this.b_0.Text = "0";
			this.b_0.UseVisualStyleBackColor = true;
			this.b_0.Click += new System.EventHandler(this.b_0_Click);
			// 
			// b_1
			// 
			this.b_1.Location = new System.Drawing.Point(6, 183);
			this.b_1.Name = "b_1";
			this.b_1.Size = new System.Drawing.Size(41, 35);
			this.b_1.TabIndex = 8;
			this.b_1.Text = "1";
			this.b_1.UseVisualStyleBackColor = true;
			this.b_1.Click += new System.EventHandler(this.b_1_Click);
			// 
			// b_4
			// 
			this.b_4.Location = new System.Drawing.Point(6, 142);
			this.b_4.Name = "b_4";
			this.b_4.Size = new System.Drawing.Size(41, 35);
			this.b_4.TabIndex = 7;
			this.b_4.Text = "4";
			this.b_4.UseVisualStyleBackColor = true;
			this.b_4.Click += new System.EventHandler(this.b_4_Click);
			// 
			// b_7
			// 
			this.b_7.Location = new System.Drawing.Point(6, 101);
			this.b_7.Name = "b_7";
			this.b_7.Size = new System.Drawing.Size(41, 35);
			this.b_7.TabIndex = 6;
			this.b_7.Text = "7";
			this.b_7.UseVisualStyleBackColor = true;
			this.b_7.Click += new System.EventHandler(this.b_7_Click);
			// 
			// b_mod
			// 
			this.b_mod.Location = new System.Drawing.Point(6, 60);
			this.b_mod.Name = "b_mod";
			this.b_mod.Size = new System.Drawing.Size(41, 35);
			this.b_mod.TabIndex = 5;
			this.b_mod.Text = "%";
			this.b_mod.UseVisualStyleBackColor = true;
			this.b_mod.Click += new System.EventHandler(this.b_mod_Click);
			// 
			// b_sin
			// 
			this.b_sin.Location = new System.Drawing.Point(6, 19);
			this.b_sin.Name = "b_sin";
			this.b_sin.Size = new System.Drawing.Size(41, 35);
			this.b_sin.TabIndex = 1;
			this.b_sin.Text = "sin";
			this.b_sin.UseVisualStyleBackColor = true;
			this.b_sin.Click += new System.EventHandler(this.b_sin_Click);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Historia});
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(238, 30);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(213, 479);
			this.listView1.TabIndex = 4;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// Historia
			// 
			this.Historia.Text = "Historia";
			this.Historia.Width = 176;
			// 
			// b_clear
			// 
			this.b_clear.Location = new System.Drawing.Point(238, 515);
			this.b_clear.Name = "b_clear";
			this.b_clear.Size = new System.Drawing.Size(213, 35);
			this.b_clear.TabIndex = 5;
			this.b_clear.Text = "wyczyść";
			this.b_clear.UseVisualStyleBackColor = true;
			this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 575);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(463, 22);
			this.statusStrip1.TabIndex = 6;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// menuStrip2
			// 
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quit_ToolStripMenuItem,
            this.setDefault_ToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(463, 24);
			this.menuStrip2.TabIndex = 8;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// quit_ToolStripMenuItem
			// 
			this.quit_ToolStripMenuItem.Name = "quit_ToolStripMenuItem";
			this.quit_ToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.quit_ToolStripMenuItem.Text = "koniec";
			this.quit_ToolStripMenuItem.Click += new System.EventHandler(this.quit_ToolStripMenuItem_Click);
			// 
			// setDefault_ToolStripMenuItem
			// 
			this.setDefault_ToolStripMenuItem.Name = "setDefault_ToolStripMenuItem";
			this.setDefault_ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.setDefault_ToolStripMenuItem.Text = "wyczyść";
			this.setDefault_ToolStripMenuItem.Click += new System.EventHandler(this.setDefault_ToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(463, 597);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip2);
			this.Controls.Add(this.b_clear);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox_wynik;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_l2;
		private System.Windows.Forms.TextBox textBox_l1;
		private System.Windows.Forms.RadioButton radioButton_liczba2;
		private System.Windows.Forms.RadioButton radioButton_liczba1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton_mod;
		private System.Windows.Forms.RadioButton radioButton_sqr;
		private System.Windows.Forms.RadioButton radioButton_sqrt;
		private System.Windows.Forms.RadioButton radioButton_cos;
		private System.Windows.Forms.RadioButton radioButton_sin;
		private System.Windows.Forms.RadioButton radioButton_add;
		private System.Windows.Forms.RadioButton radioButton_sub;
		private System.Windows.Forms.RadioButton radioButton_mul;
		private System.Windows.Forms.RadioButton radioButton_div;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button b_sin;
		private System.Windows.Forms.Button b_dot;
		private System.Windows.Forms.Button b_ent;
		private System.Windows.Forms.Button b_3;
		private System.Windows.Forms.Button b_2;
		private System.Windows.Forms.Button b_add;
		private System.Windows.Forms.Button b_6;
		private System.Windows.Forms.Button b_5;
		private System.Windows.Forms.Button b_9;
		private System.Windows.Forms.Button b_8;
		private System.Windows.Forms.Button b_sub;
		private System.Windows.Forms.Button b_mul;
		private System.Windows.Forms.Button b_div;
		private System.Windows.Forms.Button b_sqr;
		private System.Windows.Forms.Button b_sqrt;
		private System.Windows.Forms.Button b_cos;
		private System.Windows.Forms.Button b_0;
		private System.Windows.Forms.Button b_1;
		private System.Windows.Forms.Button b_4;
		private System.Windows.Forms.Button b_7;
		private System.Windows.Forms.Button b_mod;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button b_clear;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem quit_ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem setDefault_ToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader Historia;
	}
}

