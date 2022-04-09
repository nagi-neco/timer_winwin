namespace timer_winwin
{
    partial class FormSet
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonAlarm = new System.Windows.Forms.RadioButton();
            this.radioButtonTimer = new System.Windows.Forms.RadioButton();
            this.numericUpDownAlmHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTimMnt = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAlmMnt = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTimSec = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlmHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimMnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlmMnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimSec)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonAlarm
            // 
            this.radioButtonAlarm.AutoSize = true;
            this.radioButtonAlarm.Location = new System.Drawing.Point(153, 60);
            this.radioButtonAlarm.Name = "radioButtonAlarm";
            this.radioButtonAlarm.Size = new System.Drawing.Size(53, 16);
            this.radioButtonAlarm.TabIndex = 0;
            this.radioButtonAlarm.TabStop = true;
            this.radioButtonAlarm.Text = "Alarm";
            this.radioButtonAlarm.UseVisualStyleBackColor = true;
            this.radioButtonAlarm.CheckedChanged += new System.EventHandler(this.radioButtonAlarm_CheckedChanged);
            // 
            // radioButtonTimer
            // 
            this.radioButtonTimer.AutoSize = true;
            this.radioButtonTimer.Location = new System.Drawing.Point(457, 60);
            this.radioButtonTimer.Name = "radioButtonTimer";
            this.radioButtonTimer.Size = new System.Drawing.Size(52, 16);
            this.radioButtonTimer.TabIndex = 1;
            this.radioButtonTimer.TabStop = true;
            this.radioButtonTimer.Text = "Timer";
            this.radioButtonTimer.UseVisualStyleBackColor = true;
            // 
            // numericUpDownAlmHour
            // 
            this.numericUpDownAlmHour.Location = new System.Drawing.Point(153, 110);
            this.numericUpDownAlmHour.Name = "numericUpDownAlmHour";
            this.numericUpDownAlmHour.Size = new System.Drawing.Size(120, 19);
            this.numericUpDownAlmHour.TabIndex = 2;
            this.numericUpDownAlmHour.ValueChanged += new System.EventHandler(this.NumericUpDownAlarmValueChanged);
            // 
            // numericUpDownTimMnt
            // 
            this.numericUpDownTimMnt.Location = new System.Drawing.Point(457, 110);
            this.numericUpDownTimMnt.Name = "numericUpDownTimMnt";
            this.numericUpDownTimMnt.Size = new System.Drawing.Size(120, 19);
            this.numericUpDownTimMnt.TabIndex = 3;
            this.numericUpDownTimMnt.ValueChanged += new System.EventHandler(this.NumericUpDownTimerValueChanged);
            // 
            // numericUpDownAlmMnt
            // 
            this.numericUpDownAlmMnt.Location = new System.Drawing.Point(153, 190);
            this.numericUpDownAlmMnt.Name = "numericUpDownAlmMnt";
            this.numericUpDownAlmMnt.Size = new System.Drawing.Size(120, 19);
            this.numericUpDownAlmMnt.TabIndex = 4;
            this.numericUpDownAlmMnt.ValueChanged += new System.EventHandler(this.NumericUpDownAlarmValueChanged);
            // 
            // numericUpDownTimSec
            // 
            this.numericUpDownTimSec.Location = new System.Drawing.Point(457, 190);
            this.numericUpDownTimSec.Name = "numericUpDownTimSec";
            this.numericUpDownTimSec.Size = new System.Drawing.Size(120, 19);
            this.numericUpDownTimSec.TabIndex = 5;
            this.numericUpDownTimSec.ValueChanged += new System.EventHandler(this.NumericUpDownTimerValueChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(153, 264);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(457, 264);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericUpDownTimSec);
            this.Controls.Add(this.numericUpDownAlmMnt);
            this.Controls.Add(this.numericUpDownTimMnt);
            this.Controls.Add(this.numericUpDownAlmHour);
            this.Controls.Add(this.radioButtonTimer);
            this.Controls.Add(this.radioButtonAlarm);
            this.Name = "FormSet";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlmHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimMnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlmMnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimSec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAlarm;
        private System.Windows.Forms.RadioButton radioButtonTimer;
        private System.Windows.Forms.NumericUpDown numericUpDownAlmHour;
        private System.Windows.Forms.NumericUpDown numericUpDownTimMnt;
        private System.Windows.Forms.NumericUpDown numericUpDownAlmMnt;
        private System.Windows.Forms.NumericUpDown numericUpDownTimSec;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}

