namespace Loco.Collection
{
    partial class LocoCollection
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deviceList = new System.Windows.Forms.ComboBox();
            this.lblUSB = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.RichTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.monitor = new System.Windows.Forms.RichTextBox();
            this.enclosureState1 = new System.Windows.Forms.CheckBox();
            this.enclosureState2 = new System.Windows.Forms.CheckBox();
            this.enclosureState3 = new System.Windows.Forms.CheckBox();
            this.enclosureState4 = new System.Windows.Forms.CheckBox();
            this.enclosureState5 = new System.Windows.Forms.CheckBox();
            this.isDebugging = new System.Windows.Forms.CheckBox();
            this.lbSettings = new System.Windows.Forms.Label();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.btErrorClear = new System.Windows.Forms.Button();
            this.lbErrorMsg = new System.Windows.Forms.Label();
            this.gbLogging = new System.Windows.Forms.GroupBox();
            this.btCancelRequest = new System.Windows.Forms.Button();
            this.btConfirmRequest = new System.Windows.Forms.Button();
            this.cbConfirmCancel = new System.Windows.Forms.CheckBox();
            this.btCancelLogging = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlEncNum = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btStartLogging = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLogMinutes = new System.Windows.Forms.TextBox();
            this.tbLogHours = new System.Windows.Forms.TextBox();
            this.logConsole = new System.Windows.Forms.ListBox();
            this.gbListen = new System.Windows.Forms.GroupBox();
            this.gbSettings.SuspendLayout();
            this.gbLogging.SuspendLayout();
            this.gbListen.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceList
            // 
            this.deviceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceList.FormattingEnabled = true;
            this.deviceList.Location = new System.Drawing.Point(112, 12);
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(179, 21);
            this.deviceList.TabIndex = 0;
            // 
            // lblUSB
            // 
            this.lblUSB.AutoSize = true;
            this.lblUSB.Location = new System.Drawing.Point(14, 15);
            this.lblUSB.Name = "lblUSB";
            this.lblUSB.Size = new System.Drawing.Size(74, 13);
            this.lblUSB.TabIndex = 1;
            this.lblUSB.Text = "USB Devices:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(379, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Refresh List";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.MenuText;
            this.console.ForeColor = System.Drawing.SystemColors.Info;
            this.console.Location = new System.Drawing.Point(12, 477);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(611, 98);
            this.console.TabIndex = 3;
            this.console.Text = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(298, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // monitor
            // 
            this.monitor.BackColor = System.Drawing.SystemColors.MenuText;
            this.monitor.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitor.ForeColor = System.Drawing.SystemColors.Window;
            this.monitor.Location = new System.Drawing.Point(12, 79);
            this.monitor.Name = "monitor";
            this.monitor.Size = new System.Drawing.Size(150, 389);
            this.monitor.TabIndex = 8;
            this.monitor.Text = "";
            // 
            // enclosureState1
            // 
            this.enclosureState1.AutoSize = true;
            this.enclosureState1.Location = new System.Drawing.Point(6, 19);
            this.enclosureState1.Name = "enclosureState1";
            this.enclosureState1.Size = new System.Drawing.Size(32, 17);
            this.enclosureState1.TabIndex = 9;
            this.enclosureState1.Text = "1";
            this.enclosureState1.UseVisualStyleBackColor = true;
            // 
            // enclosureState2
            // 
            this.enclosureState2.AutoSize = true;
            this.enclosureState2.Location = new System.Drawing.Point(6, 42);
            this.enclosureState2.Name = "enclosureState2";
            this.enclosureState2.Size = new System.Drawing.Size(32, 17);
            this.enclosureState2.TabIndex = 10;
            this.enclosureState2.Text = "2";
            this.enclosureState2.UseVisualStyleBackColor = true;
            // 
            // enclosureState3
            // 
            this.enclosureState3.AutoSize = true;
            this.enclosureState3.Location = new System.Drawing.Point(6, 65);
            this.enclosureState3.Name = "enclosureState3";
            this.enclosureState3.Size = new System.Drawing.Size(32, 17);
            this.enclosureState3.TabIndex = 11;
            this.enclosureState3.Text = "3";
            this.enclosureState3.UseVisualStyleBackColor = true;
            // 
            // enclosureState4
            // 
            this.enclosureState4.AutoSize = true;
            this.enclosureState4.Location = new System.Drawing.Point(6, 88);
            this.enclosureState4.Name = "enclosureState4";
            this.enclosureState4.Size = new System.Drawing.Size(32, 17);
            this.enclosureState4.TabIndex = 12;
            this.enclosureState4.Text = "4";
            this.enclosureState4.UseVisualStyleBackColor = true;
            // 
            // enclosureState5
            // 
            this.enclosureState5.AutoSize = true;
            this.enclosureState5.Location = new System.Drawing.Point(6, 111);
            this.enclosureState5.Name = "enclosureState5";
            this.enclosureState5.Size = new System.Drawing.Size(32, 17);
            this.enclosureState5.TabIndex = 13;
            this.enclosureState5.Text = "5";
            this.enclosureState5.UseVisualStyleBackColor = true;
            // 
            // isDebugging
            // 
            this.isDebugging.AutoSize = true;
            this.isDebugging.Location = new System.Drawing.Point(565, 10);
            this.isDebugging.Name = "isDebugging";
            this.isDebugging.Size = new System.Drawing.Size(58, 17);
            this.isDebugging.TabIndex = 15;
            this.isDebugging.Text = "Debug";
            this.isDebugging.UseVisualStyleBackColor = true;
            // 
            // lbSettings
            // 
            this.lbSettings.AutoSize = true;
            this.lbSettings.Location = new System.Drawing.Point(374, 57);
            this.lbSettings.Name = "lbSettings";
            this.lbSettings.Size = new System.Drawing.Size(0, 13);
            this.lbSettings.TabIndex = 19;
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.btErrorClear);
            this.gbSettings.Controls.Add(this.lbErrorMsg);
            this.gbSettings.Controls.Add(this.gbLogging);
            this.gbSettings.Controls.Add(this.gbListen);
            this.gbSettings.Location = new System.Drawing.Point(176, 79);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(447, 389);
            this.gbSettings.TabIndex = 20;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Enclosure Settings";
            // 
            // btErrorClear
            // 
            this.btErrorClear.Location = new System.Drawing.Point(12, 296);
            this.btErrorClear.Name = "btErrorClear";
            this.btErrorClear.Size = new System.Drawing.Size(91, 23);
            this.btErrorClear.TabIndex = 28;
            this.btErrorClear.Text = "Clear Message";
            this.btErrorClear.UseVisualStyleBackColor = true;
            this.btErrorClear.Visible = false;
            this.btErrorClear.Click += new System.EventHandler(this.btErrorClear_Click);
            // 
            // lbErrorMsg
            // 
            this.lbErrorMsg.AutoSize = true;
            this.lbErrorMsg.Location = new System.Drawing.Point(9, 279);
            this.lbErrorMsg.Name = "lbErrorMsg";
            this.lbErrorMsg.Size = new System.Drawing.Size(49, 13);
            this.lbErrorMsg.TabIndex = 27;
            this.lbErrorMsg.Text = "ErrorMsg";
            this.lbErrorMsg.Visible = false;
            // 
            // gbLogging
            // 
            this.gbLogging.Controls.Add(this.btCancelRequest);
            this.gbLogging.Controls.Add(this.btConfirmRequest);
            this.gbLogging.Controls.Add(this.cbConfirmCancel);
            this.gbLogging.Controls.Add(this.btCancelLogging);
            this.gbLogging.Controls.Add(this.label7);
            this.gbLogging.Controls.Add(this.label6);
            this.gbLogging.Controls.Add(this.ddlEncNum);
            this.gbLogging.Controls.Add(this.label5);
            this.gbLogging.Controls.Add(this.btStartLogging);
            this.gbLogging.Controls.Add(this.label4);
            this.gbLogging.Controls.Add(this.label3);
            this.gbLogging.Controls.Add(this.label2);
            this.gbLogging.Controls.Add(this.label1);
            this.gbLogging.Controls.Add(this.tbLogMinutes);
            this.gbLogging.Controls.Add(this.tbLogHours);
            this.gbLogging.Controls.Add(this.logConsole);
            this.gbLogging.Location = new System.Drawing.Point(66, 19);
            this.gbLogging.Name = "gbLogging";
            this.gbLogging.Size = new System.Drawing.Size(375, 244);
            this.gbLogging.TabIndex = 2;
            this.gbLogging.TabStop = false;
            this.gbLogging.Text = "Logging";
            // 
            // btCancelRequest
            // 
            this.btCancelRequest.Location = new System.Drawing.Point(261, 65);
            this.btCancelRequest.Name = "btCancelRequest";
            this.btCancelRequest.Size = new System.Drawing.Size(100, 23);
            this.btCancelRequest.TabIndex = 26;
            this.btCancelRequest.Text = "Cancel";
            this.btCancelRequest.UseVisualStyleBackColor = true;
            this.btCancelRequest.Visible = false;
            this.btCancelRequest.Click += new System.EventHandler(this.btCancelRequest_Click);
            // 
            // btConfirmRequest
            // 
            this.btConfirmRequest.Location = new System.Drawing.Point(261, 111);
            this.btConfirmRequest.Name = "btConfirmRequest";
            this.btConfirmRequest.Size = new System.Drawing.Size(100, 23);
            this.btConfirmRequest.TabIndex = 25;
            this.btConfirmRequest.Text = "Confirm Cancel";
            this.btConfirmRequest.UseVisualStyleBackColor = true;
            this.btConfirmRequest.Visible = false;
            this.btConfirmRequest.Click += new System.EventHandler(this.btConfirmRequest_Click);
            // 
            // cbConfirmCancel
            // 
            this.cbConfirmCancel.AutoSize = true;
            this.cbConfirmCancel.Location = new System.Drawing.Point(261, 94);
            this.cbConfirmCancel.Name = "cbConfirmCancel";
            this.cbConfirmCancel.Size = new System.Drawing.Size(95, 17);
            this.cbConfirmCancel.TabIndex = 24;
            this.cbConfirmCancel.Text = "Are You Sure?";
            this.cbConfirmCancel.UseVisualStyleBackColor = true;
            this.cbConfirmCancel.Visible = false;
            this.cbConfirmCancel.CheckedChanged += new System.EventHandler(this.cbConfirmCancel_CheckedChanged);
            // 
            // btCancelLogging
            // 
            this.btCancelLogging.Location = new System.Drawing.Point(261, 39);
            this.btCancelLogging.Name = "btCancelLogging";
            this.btCancelLogging.Size = new System.Drawing.Size(100, 23);
            this.btCancelLogging.TabIndex = 23;
            this.btCancelLogging.Text = "Cancel Logging";
            this.btCancelLogging.UseVisualStyleBackColor = true;
            this.btCancelLogging.Click += new System.EventHandler(this.btCancelLogging_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cancel Logging Task:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Enclosure#:";
            // 
            // ddlEncNum
            // 
            this.ddlEncNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEncNum.FormattingEnabled = true;
            this.ddlEncNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ddlEncNum.Location = new System.Drawing.Point(10, 212);
            this.ddlEncNum.Name = "ddlEncNum";
            this.ddlEncNum.Size = new System.Drawing.Size(80, 21);
            this.ddlEncNum.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Duration:";
            // 
            // btStartLogging
            // 
            this.btStartLogging.Location = new System.Drawing.Point(184, 209);
            this.btStartLogging.Name = "btStartLogging";
            this.btStartLogging.Size = new System.Drawing.Size(85, 23);
            this.btStartLogging.TabIndex = 18;
            this.btStartLogging.Text = "Start Logging";
            this.btStartLogging.UseVisualStyleBackColor = true;
            this.btStartLogging.Click += new System.EventHandler(this.btStartLogging_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Logging Setup:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Logging Status:";
            // 
            // tbLogMinutes
            // 
            this.tbLogMinutes.Location = new System.Drawing.Point(137, 212);
            this.tbLogMinutes.Multiline = true;
            this.tbLogMinutes.Name = "tbLogMinutes";
            this.tbLogMinutes.Size = new System.Drawing.Size(24, 20);
            this.tbLogMinutes.TabIndex = 13;
            // 
            // tbLogHours
            // 
            this.tbLogHours.Location = new System.Drawing.Point(96, 212);
            this.tbLogHours.Name = "tbLogHours";
            this.tbLogHours.Size = new System.Drawing.Size(24, 20);
            this.tbLogHours.TabIndex = 12;
            // 
            // logConsole
            // 
            this.logConsole.FormattingEnabled = true;
            this.logConsole.Location = new System.Drawing.Point(10, 42);
            this.logConsole.Name = "logConsole";
            this.logConsole.Size = new System.Drawing.Size(245, 108);
            this.logConsole.TabIndex = 11;
            // 
            // gbListen
            // 
            this.gbListen.Controls.Add(this.enclosureState1);
            this.gbListen.Controls.Add(this.enclosureState2);
            this.gbListen.Controls.Add(this.enclosureState3);
            this.gbListen.Controls.Add(this.enclosureState5);
            this.gbListen.Controls.Add(this.enclosureState4);
            this.gbListen.Location = new System.Drawing.Point(6, 19);
            this.gbListen.Name = "gbListen";
            this.gbListen.Size = new System.Drawing.Size(54, 134);
            this.gbListen.TabIndex = 0;
            this.gbListen.TabStop = false;
            this.gbListen.Text = "Listen:";
            // 
            // LocoCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 586);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.lbSettings);
            this.Controls.Add(this.isDebugging);
            this.Controls.Add(this.monitor);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.console);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblUSB);
            this.Controls.Add(this.deviceList);
            this.MaximumSize = new System.Drawing.Size(651, 625);
            this.MinimumSize = new System.Drawing.Size(651, 625);
            this.Name = "LocoCollection";
            this.Text = "Locomotor Data Collector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbLogging.ResumeLayout(false);
            this.gbLogging.PerformLayout();
            this.gbListen.ResumeLayout(false);
            this.gbListen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox deviceList;
        private System.Windows.Forms.Label lblUSB;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RichTextBox monitor;
        private System.Windows.Forms.CheckBox enclosureState1;
        private System.Windows.Forms.CheckBox enclosureState2;
        private System.Windows.Forms.CheckBox enclosureState3;
        private System.Windows.Forms.CheckBox enclosureState4;
        private System.Windows.Forms.CheckBox enclosureState5;
        private System.Windows.Forms.CheckBox isDebugging;
        private System.Windows.Forms.Label lbSettings;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.GroupBox gbListen;
        private System.Windows.Forms.GroupBox gbLogging;
        private System.Windows.Forms.Button btCancelRequest;
        private System.Windows.Forms.Button btConfirmRequest;
        private System.Windows.Forms.CheckBox cbConfirmCancel;
        private System.Windows.Forms.Button btCancelLogging;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlEncNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btStartLogging;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLogMinutes;
        private System.Windows.Forms.TextBox tbLogHours;
        private System.Windows.Forms.ListBox logConsole;
        private System.Windows.Forms.Button btErrorClear;
        private System.Windows.Forms.Label lbErrorMsg;
    }
}

