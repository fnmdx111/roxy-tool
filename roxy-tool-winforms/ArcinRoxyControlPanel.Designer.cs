﻿namespace Roxy.Tool.WinForms
{
    partial class ArcinRoxyControlPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ascEmuCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.debounceNum = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialNumCheck = new System.Windows.Forms.CheckBox();
            this.invertQE1Check = new System.Windows.Forms.CheckBox();
            this.invertQE2Check = new System.Windows.Forms.CheckBox();
            this.led1Check = new System.Windows.Forms.CheckBox();
            this.led2Check = new System.Windows.Forms.CheckBox();
            this.analogInputCheck = new System.Windows.Forms.CheckBox();
            this.analogButtonsCheck = new System.Windows.Forms.CheckBox();
            this.axisDebounceNum = new System.Windows.Forms.NumericUpDown();
            this.ws2812bCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ps2Combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qe2Combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.qe1Combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.invertLightsCheck = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.keyMapButton = new System.Windows.Forms.Button();
            this.controllerOutputCombo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonLedModeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.debounceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisDebounceNum)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 709);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 25);
            this.label9.TabIndex = 71;
            this.label9.Text = "ms";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 709);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 25);
            this.label11.TabIndex = 69;
            this.label11.Text = "Axis Debounce";
            // 
            // ascEmuCombo
            // 
            this.ascEmuCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ascEmuCombo.FormattingEnabled = true;
            this.ascEmuCombo.Items.AddRange(new object[] {
            "Disabled",
            "IIDX premium",
            "SDVX NEMSYS entry"});
            this.ascEmuCombo.Location = new System.Drawing.Point(174, 655);
            this.ascEmuCombo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ascEmuCombo.Name = "ascEmuCombo";
            this.ascEmuCombo.Size = new System.Drawing.Size(270, 32);
            this.ascEmuCombo.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 661);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 25);
            this.label10.TabIndex = 67;
            this.label10.Text = "ASC Emulation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 611);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 25);
            this.label7.TabIndex = 66;
            this.label7.Text = "ms";
            // 
            // debounceNum
            // 
            this.debounceNum.Location = new System.Drawing.Point(174, 607);
            this.debounceNum.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.debounceNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.debounceNum.Name = "debounceNum";
            this.debounceNum.Size = new System.Drawing.Size(226, 29);
            this.debounceNum.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 611);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 25);
            this.label8.TabIndex = 64;
            this.label8.Text = "Debounce Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Flags:";
            // 
            // labelText
            // 
            this.labelText.Location = new System.Drawing.Point(174, 6);
            this.labelText.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelText.MaxLength = 11;
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(270, 29);
            this.labelText.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "Board Label:";
            // 
            // serialNumCheck
            // 
            this.serialNumCheck.AutoSize = true;
            this.serialNumCheck.Location = new System.Drawing.Point(6, 6);
            this.serialNumCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.serialNumCheck.Name = "serialNumCheck";
            this.serialNumCheck.Size = new System.Drawing.Size(207, 29);
            this.serialNumCheck.TabIndex = 0;
            this.serialNumCheck.Text = "Hide Serial Number";
            this.serialNumCheck.UseVisualStyleBackColor = true;
            // 
            // invertQE1Check
            // 
            this.invertQE1Check.AutoSize = true;
            this.invertQE1Check.Location = new System.Drawing.Point(6, 47);
            this.invertQE1Check.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.invertQE1Check.Name = "invertQE1Check";
            this.invertQE1Check.Size = new System.Drawing.Size(131, 29);
            this.invertQE1Check.TabIndex = 1;
            this.invertQE1Check.Text = "Invert QE1";
            this.invertQE1Check.UseVisualStyleBackColor = true;
            // 
            // invertQE2Check
            // 
            this.invertQE2Check.AutoSize = true;
            this.invertQE2Check.Location = new System.Drawing.Point(6, 88);
            this.invertQE2Check.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.invertQE2Check.Name = "invertQE2Check";
            this.invertQE2Check.Size = new System.Drawing.Size(131, 29);
            this.invertQE2Check.TabIndex = 2;
            this.invertQE2Check.Text = "Invert QE2";
            this.invertQE2Check.UseVisualStyleBackColor = true;
            // 
            // led1Check
            // 
            this.led1Check.AutoSize = true;
            this.led1Check.Location = new System.Drawing.Point(6, 129);
            this.led1Check.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.led1Check.Name = "led1Check";
            this.led1Check.Size = new System.Drawing.Size(179, 29);
            this.led1Check.TabIndex = 3;
            this.led1Check.Text = "LED1 always on";
            this.led1Check.UseVisualStyleBackColor = true;
            // 
            // led2Check
            // 
            this.led2Check.AutoSize = true;
            this.led2Check.Location = new System.Drawing.Point(6, 170);
            this.led2Check.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.led2Check.Name = "led2Check";
            this.led2Check.Size = new System.Drawing.Size(179, 29);
            this.led2Check.TabIndex = 4;
            this.led2Check.Text = "LED2 always on";
            this.led2Check.UseVisualStyleBackColor = true;
            // 
            // analogInputCheck
            // 
            this.analogInputCheck.AutoSize = true;
            this.analogInputCheck.Location = new System.Drawing.Point(6, 211);
            this.analogInputCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.analogInputCheck.Name = "analogInputCheck";
            this.analogInputCheck.Size = new System.Drawing.Size(231, 29);
            this.analogInputCheck.TabIndex = 7;
            this.analogInputCheck.Text = "Analog Input (Not QE)";
            this.analogInputCheck.UseVisualStyleBackColor = true;
            // 
            // analogButtonsCheck
            // 
            this.analogButtonsCheck.AutoSize = true;
            this.analogButtonsCheck.Location = new System.Drawing.Point(6, 252);
            this.analogButtonsCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.analogButtonsCheck.Name = "analogButtonsCheck";
            this.analogButtonsCheck.Size = new System.Drawing.Size(237, 29);
            this.analogButtonsCheck.TabIndex = 6;
            this.analogButtonsCheck.Text = "Enable Analog Buttons";
            this.analogButtonsCheck.UseVisualStyleBackColor = true;
            // 
            // axisDebounceNum
            // 
            this.axisDebounceNum.Location = new System.Drawing.Point(174, 705);
            this.axisDebounceNum.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.axisDebounceNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.axisDebounceNum.Name = "axisDebounceNum";
            this.axisDebounceNum.Size = new System.Drawing.Size(226, 29);
            this.axisDebounceNum.TabIndex = 70;
            // 
            // ws2812bCombo
            // 
            this.ws2812bCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ws2812bCombo.FormattingEnabled = true;
            this.ws2812bCombo.Items.AddRange(new object[] {
            "Disabled",
            "B9"});
            this.ws2812bCombo.Location = new System.Drawing.Point(174, 558);
            this.ws2812bCombo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ws2812bCombo.Name = "ws2812bCombo";
            this.ws2812bCombo.Size = new System.Drawing.Size(270, 32);
            this.ws2812bCombo.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 563);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "WS2812B Mode";
            // 
            // ps2Combo
            // 
            this.ps2Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ps2Combo.FormattingEnabled = true;
            this.ps2Combo.Items.AddRange(new object[] {
            "Disabled",
            "Pop\'n Music",
            "IIDX (QE1)",
            "IIDX (QE2)"});
            this.ps2Combo.Location = new System.Drawing.Point(174, 508);
            this.ps2Combo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ps2Combo.Name = "ps2Combo";
            this.ps2Combo.Size = new System.Drawing.Size(270, 32);
            this.ps2Combo.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 513);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 60;
            this.label5.Text = "PS2 Mode";
            // 
            // qe2Combo
            // 
            this.qe2Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qe2Combo.FormattingEnabled = true;
            this.qe2Combo.Location = new System.Drawing.Point(174, 458);
            this.qe2Combo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.qe2Combo.Name = "qe2Combo";
            this.qe2Combo.Size = new System.Drawing.Size(270, 32);
            this.qe2Combo.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 463);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "QE2 Sensitivity";
            // 
            // qe1Combo
            // 
            this.qe1Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qe1Combo.FormattingEnabled = true;
            this.qe1Combo.Location = new System.Drawing.Point(174, 408);
            this.qe1Combo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.qe1Combo.Name = "qe1Combo";
            this.qe1Combo.Size = new System.Drawing.Size(270, 32);
            this.qe1Combo.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 414);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "QE1 Sensitivity";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.serialNumCheck);
            this.flowLayoutPanel1.Controls.Add(this.invertQE1Check);
            this.flowLayoutPanel1.Controls.Add(this.invertQE2Check);
            this.flowLayoutPanel1.Controls.Add(this.led1Check);
            this.flowLayoutPanel1.Controls.Add(this.led2Check);
            this.flowLayoutPanel1.Controls.Add(this.analogInputCheck);
            this.flowLayoutPanel1.Controls.Add(this.analogButtonsCheck);
            this.flowLayoutPanel1.Controls.Add(this.invertLightsCheck);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(174, 54);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(273, 343);
            this.flowLayoutPanel1.TabIndex = 55;
            // 
            // invertLightsCheck
            // 
            this.invertLightsCheck.AutoSize = true;
            this.invertLightsCheck.Location = new System.Drawing.Point(6, 293);
            this.invertLightsCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.invertLightsCheck.Name = "invertLightsCheck";
            this.invertLightsCheck.Size = new System.Drawing.Size(204, 29);
            this.invertLightsCheck.TabIndex = 8;
            this.invertLightsCheck.Text = "Invert Button Lights";
            this.invertLightsCheck.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 812);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 25);
            this.label14.TabIndex = 82;
            this.label14.Text = "Key Mapping";
            // 
            // keyMapButton
            // 
            this.keyMapButton.Location = new System.Drawing.Point(172, 803);
            this.keyMapButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.keyMapButton.Name = "keyMapButton";
            this.keyMapButton.Size = new System.Drawing.Size(282, 42);
            this.keyMapButton.TabIndex = 81;
            this.keyMapButton.Text = "Keyboard Mapping";
            this.keyMapButton.UseVisualStyleBackColor = true;
            this.keyMapButton.Click += new System.EventHandler(this.keyMapButton_Click);
            // 
            // controllerOutputCombo
            // 
            this.controllerOutputCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controllerOutputCombo.FormattingEnabled = true;
            this.controllerOutputCombo.Items.AddRange(new object[] {
            "Joystick",
            "Keyboard",
            "Joystick + Keyboard"});
            this.controllerOutputCombo.Location = new System.Drawing.Point(174, 753);
            this.controllerOutputCombo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.controllerOutputCombo.Name = "controllerOutputCombo";
            this.controllerOutputCombo.Size = new System.Drawing.Size(277, 32);
            this.controllerOutputCombo.TabIndex = 80;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 759);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 25);
            this.label13.TabIndex = 79;
            this.label13.Text = "Controller Output";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 866);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 25);
            this.label15.TabIndex = 84;
            this.label15.Text = "Button LED Mode";
            // 
            // buttonLedModeButton
            // 
            this.buttonLedModeButton.Location = new System.Drawing.Point(172, 857);
            this.buttonLedModeButton.Margin = new System.Windows.Forms.Padding(6);
            this.buttonLedModeButton.Name = "buttonLedModeButton";
            this.buttonLedModeButton.Size = new System.Drawing.Size(282, 42);
            this.buttonLedModeButton.TabIndex = 83;
            this.buttonLedModeButton.Text = "Button LED Mode";
            this.buttonLedModeButton.UseVisualStyleBackColor = true;
            this.buttonLedModeButton.Click += new System.EventHandler(this.buttonLedModeButton_Click);
            // 
            // ArcinRoxyControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label15);
            this.Controls.Add(this.buttonLedModeButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.keyMapButton);
            this.Controls.Add(this.controllerOutputCombo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ascEmuCombo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.debounceNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axisDebounceNum);
            this.Controls.Add(this.ws2812bCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ps2Combo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.qe2Combo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qe1Combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ArcinRoxyControlPanel";
            this.Size = new System.Drawing.Size(458, 914);
            ((System.ComponentModel.ISupportInitialize)(this.debounceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisDebounceNum)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ascEmuCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown debounceNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox labelText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox serialNumCheck;
        private System.Windows.Forms.CheckBox invertQE1Check;
        private System.Windows.Forms.CheckBox invertQE2Check;
        private System.Windows.Forms.CheckBox led1Check;
        private System.Windows.Forms.CheckBox led2Check;
        private System.Windows.Forms.CheckBox analogInputCheck;
        private System.Windows.Forms.CheckBox analogButtonsCheck;
        private System.Windows.Forms.NumericUpDown axisDebounceNum;
        private System.Windows.Forms.ComboBox ws2812bCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ps2Combo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox qe2Combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox qe1Combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button keyMapButton;
        private System.Windows.Forms.ComboBox controllerOutputCombo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox invertLightsCheck;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonLedModeButton;
    }
}
