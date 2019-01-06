namespace SchedulingUI
{
    partial class EditCustomer
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
            this.cancelEditCustBtn = new System.Windows.Forms.Button();
            this.saveEditCustBtn = new System.Windows.Forms.Button();
            this.editCustomerGroup = new System.Windows.Forms.GroupBox();
            this.editPhoneLabel = new System.Windows.Forms.Label();
            this.editCountryLabel = new System.Windows.Forms.Label();
            this.editPostalLabel = new System.Windows.Forms.Label();
            this.editCityLabel = new System.Windows.Forms.Label();
            this.editAddr2Label = new System.Windows.Forms.Label();
            this.editAddr1Label = new System.Windows.Forms.Label();
            this.editCustNameLabel = new System.Windows.Forms.Label();
            this.editPhoneTextbox = new System.Windows.Forms.TextBox();
            this.editPostalTextbox = new System.Windows.Forms.TextBox();
            this.editCityTextbox = new System.Windows.Forms.TextBox();
            this.editAddr2Textbox = new System.Windows.Forms.TextBox();
            this.editAddr1Textbox = new System.Windows.Forms.TextBox();
            this.editCustNameTextbox = new System.Windows.Forms.TextBox();
            this.editCountrySelectBox = new System.Windows.Forms.ComboBox();
            this.editCustomerGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelEditCustBtn
            // 
            this.cancelEditCustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelEditCustBtn.Location = new System.Drawing.Point(246, 392);
            this.cancelEditCustBtn.Name = "cancelEditCustBtn";
            this.cancelEditCustBtn.Size = new System.Drawing.Size(98, 23);
            this.cancelEditCustBtn.TabIndex = 14;
            this.cancelEditCustBtn.Text = "Cancel";
            this.cancelEditCustBtn.UseVisualStyleBackColor = true;
            this.cancelEditCustBtn.Click += new System.EventHandler(this.cancelEditCustBtn_Click);
            // 
            // saveEditCustBtn
            // 
            this.saveEditCustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEditCustBtn.Location = new System.Drawing.Point(111, 392);
            this.saveEditCustBtn.Name = "saveEditCustBtn";
            this.saveEditCustBtn.Size = new System.Drawing.Size(129, 23);
            this.saveEditCustBtn.TabIndex = 13;
            this.saveEditCustBtn.Text = "Save";
            this.saveEditCustBtn.UseVisualStyleBackColor = true;
            this.saveEditCustBtn.Click += new System.EventHandler(this.saveEditCustBtn_Click);
            // 
            // editCustomerGroup
            // 
            this.editCustomerGroup.Controls.Add(this.editCountrySelectBox);
            this.editCustomerGroup.Controls.Add(this.editPhoneLabel);
            this.editCustomerGroup.Controls.Add(this.editCountryLabel);
            this.editCustomerGroup.Controls.Add(this.editPostalLabel);
            this.editCustomerGroup.Controls.Add(this.editCityLabel);
            this.editCustomerGroup.Controls.Add(this.editAddr2Label);
            this.editCustomerGroup.Controls.Add(this.editAddr1Label);
            this.editCustomerGroup.Controls.Add(this.editCustNameLabel);
            this.editCustomerGroup.Controls.Add(this.editPhoneTextbox);
            this.editCustomerGroup.Controls.Add(this.editPostalTextbox);
            this.editCustomerGroup.Controls.Add(this.editCityTextbox);
            this.editCustomerGroup.Controls.Add(this.editAddr2Textbox);
            this.editCustomerGroup.Controls.Add(this.editAddr1Textbox);
            this.editCustomerGroup.Controls.Add(this.editCustNameTextbox);
            this.editCustomerGroup.Location = new System.Drawing.Point(24, 22);
            this.editCustomerGroup.Name = "editCustomerGroup";
            this.editCustomerGroup.Size = new System.Drawing.Size(320, 342);
            this.editCustomerGroup.TabIndex = 12;
            this.editCustomerGroup.TabStop = false;
            this.editCustomerGroup.Text = "Edit Customer";
            // 
            // editPhoneLabel
            // 
            this.editPhoneLabel.AutoSize = true;
            this.editPhoneLabel.Location = new System.Drawing.Point(58, 284);
            this.editPhoneLabel.Name = "editPhoneLabel";
            this.editPhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.editPhoneLabel.TabIndex = 13;
            this.editPhoneLabel.Text = "Phone";
            // 
            // editCountryLabel
            // 
            this.editCountryLabel.AutoSize = true;
            this.editCountryLabel.Location = new System.Drawing.Point(58, 249);
            this.editCountryLabel.Name = "editCountryLabel";
            this.editCountryLabel.Size = new System.Drawing.Size(43, 13);
            this.editCountryLabel.TabIndex = 12;
            this.editCountryLabel.Text = "Country";
            // 
            // editPostalLabel
            // 
            this.editPostalLabel.AutoSize = true;
            this.editPostalLabel.Location = new System.Drawing.Point(58, 214);
            this.editPostalLabel.Name = "editPostalLabel";
            this.editPostalLabel.Size = new System.Drawing.Size(64, 13);
            this.editPostalLabel.TabIndex = 11;
            this.editPostalLabel.Text = "Postal Code";
            // 
            // editCityLabel
            // 
            this.editCityLabel.AutoSize = true;
            this.editCityLabel.Location = new System.Drawing.Point(58, 178);
            this.editCityLabel.Name = "editCityLabel";
            this.editCityLabel.Size = new System.Drawing.Size(24, 13);
            this.editCityLabel.TabIndex = 10;
            this.editCityLabel.Text = "City";
            // 
            // editAddr2Label
            // 
            this.editAddr2Label.AutoSize = true;
            this.editAddr2Label.Location = new System.Drawing.Point(58, 138);
            this.editAddr2Label.Name = "editAddr2Label";
            this.editAddr2Label.Size = new System.Drawing.Size(54, 13);
            this.editAddr2Label.TabIndex = 9;
            this.editAddr2Label.Text = "Address 2";
            // 
            // editAddr1Label
            // 
            this.editAddr1Label.AutoSize = true;
            this.editAddr1Label.Location = new System.Drawing.Point(58, 105);
            this.editAddr1Label.Name = "editAddr1Label";
            this.editAddr1Label.Size = new System.Drawing.Size(54, 13);
            this.editAddr1Label.TabIndex = 8;
            this.editAddr1Label.Text = "Address 1";
            // 
            // editCustNameLabel
            // 
            this.editCustNameLabel.AutoSize = true;
            this.editCustNameLabel.Location = new System.Drawing.Point(58, 61);
            this.editCustNameLabel.Name = "editCustNameLabel";
            this.editCustNameLabel.Size = new System.Drawing.Size(82, 13);
            this.editCustNameLabel.TabIndex = 7;
            this.editCustNameLabel.Text = "Customer Name";
            // 
            // editPhoneTextbox
            // 
            this.editPhoneTextbox.Location = new System.Drawing.Point(146, 281);
            this.editPhoneTextbox.Name = "editPhoneTextbox";
            this.editPhoneTextbox.Size = new System.Drawing.Size(168, 20);
            this.editPhoneTextbox.TabIndex = 6;
            // 
            // editPostalTextbox
            // 
            this.editPostalTextbox.Location = new System.Drawing.Point(146, 211);
            this.editPostalTextbox.Name = "editPostalTextbox";
            this.editPostalTextbox.Size = new System.Drawing.Size(168, 20);
            this.editPostalTextbox.TabIndex = 4;
            // 
            // editCityTextbox
            // 
            this.editCityTextbox.Location = new System.Drawing.Point(146, 175);
            this.editCityTextbox.Name = "editCityTextbox";
            this.editCityTextbox.Size = new System.Drawing.Size(168, 20);
            this.editCityTextbox.TabIndex = 3;
            // 
            // editAddr2Textbox
            // 
            this.editAddr2Textbox.Location = new System.Drawing.Point(146, 135);
            this.editAddr2Textbox.Name = "editAddr2Textbox";
            this.editAddr2Textbox.Size = new System.Drawing.Size(168, 20);
            this.editAddr2Textbox.TabIndex = 2;
            // 
            // editAddr1Textbox
            // 
            this.editAddr1Textbox.Location = new System.Drawing.Point(146, 98);
            this.editAddr1Textbox.Name = "editAddr1Textbox";
            this.editAddr1Textbox.Size = new System.Drawing.Size(168, 20);
            this.editAddr1Textbox.TabIndex = 1;
            // 
            // editCustNameTextbox
            // 
            this.editCustNameTextbox.Location = new System.Drawing.Point(146, 58);
            this.editCustNameTextbox.Name = "editCustNameTextbox";
            this.editCustNameTextbox.Size = new System.Drawing.Size(168, 20);
            this.editCustNameTextbox.TabIndex = 0;
            // 
            // editCountrySelectBox
            // 
            this.editCountrySelectBox.FormattingEnabled = true;
            this.editCountrySelectBox.Items.AddRange(new object[] {
            "Afghanistan",
            "Åland Islands",
            "Albania",
            "Algeria",
            "American Samoa",
            "Andorra",
            "Angola",
            "Anguilla",
            "Antarctica",
            "Antigua & Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Ascension Island",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bermuda",
            "Bhutan",
            "Bolivia",
            "Bosnia & Herzegovina",
            "Botswana",
            "Brazil",
            "British Indian Ocean Territory",
            "British Virgin Islands",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Canary Islands",
            "Cape Verde",
            "Caribbean Netherlands",
            "Cayman Islands",
            "Central African Republic",
            "Ceuta & Melilla",
            "Chad",
            "Chile",
            "China",
            "Christmas Island",
            "Cocos (Keeling) Islands",
            "Colombia",
            "Comoros",
            "Congo - Brazzaville",
            "Congo - Kinshasa",
            "Cook Islands",
            "Costa Rica",
            "Côte d’Ivoire",
            "Croatia",
            "Cuba",
            "Curaçao",
            "Cyprus",
            "Czechia",
            "Denmark",
            "Diego Garcia",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Eurozone",
            "Falkland Islands",
            "Faroe Islands",
            "Fiji",
            "Finland",
            "France",
            "French Guiana",
            "French Polynesia",
            "French Southern Territories",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Gibraltar",
            "Greece",
            "Greenland",
            "Grenada",
            "Guadeloupe",
            "Guam",
            "Guatemala",
            "Guernsey",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hong Kong SAR China",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Isle of Man",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jersey",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macau SAR China",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Martinique",
            "Mauritania",
            "Mauritius",
            "Mayotte",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Montserrat",
            "Morocco",
            "Mozambique",
            "Myanmar (Burma)",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Caledonia",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Niue",
            "Norfolk Island",
            "North Korea",
            "Northern Mariana Islands",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestinian Territories",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Pitcairn Islands",
            "Poland",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Réunion",
            "Romania",
            "Russia",
            "Rwanda",
            "Samoa",
            "San Marino",
            "São Tomé & Príncipe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Sint Maarten",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Georgia & South Sandwich Islands",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "St. Barthélemy",
            "St. Helena",
            "St. Kitts & Nevis",
            "St. Lucia",
            "St. Martin",
            "St. Pierre & Miquelon",
            "St. Vincent & Grenadines",
            "Sudan",
            "Suriname",
            "Svalbard & Jan Mayen",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trinidad & Tobago",
            "Tristan da Cunha",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Turks & Caicos Islands",
            "Tuvalu",
            "U.S. Outlying Islands",
            "U.S. Virgin Islands",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United Nations",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Wallis & Futuna",
            "Western Sahara",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.editCountrySelectBox.Location = new System.Drawing.Point(146, 246);
            this.editCountrySelectBox.Name = "editCountrySelectBox";
            this.editCountrySelectBox.Size = new System.Drawing.Size(168, 21);
            this.editCountrySelectBox.TabIndex = 15;
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.cancelEditCustBtn);
            this.Controls.Add(this.saveEditCustBtn);
            this.Controls.Add(this.editCustomerGroup);
            this.Name = "EditCustomer";
            this.Text = "Edit Customer";
            this.editCustomerGroup.ResumeLayout(false);
            this.editCustomerGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelEditCustBtn;
        private System.Windows.Forms.Button saveEditCustBtn;
        private System.Windows.Forms.GroupBox editCustomerGroup;
        private System.Windows.Forms.Label editPhoneLabel;
        private System.Windows.Forms.Label editCountryLabel;
        private System.Windows.Forms.Label editPostalLabel;
        private System.Windows.Forms.Label editCityLabel;
        private System.Windows.Forms.Label editAddr2Label;
        private System.Windows.Forms.Label editAddr1Label;
        private System.Windows.Forms.Label editCustNameLabel;
        private System.Windows.Forms.TextBox editPhoneTextbox;
        private System.Windows.Forms.TextBox editPostalTextbox;
        private System.Windows.Forms.TextBox editCityTextbox;
        private System.Windows.Forms.TextBox editAddr2Textbox;
        private System.Windows.Forms.TextBox editAddr1Textbox;
        private System.Windows.Forms.TextBox editCustNameTextbox;
        private System.Windows.Forms.ComboBox editCountrySelectBox;
    }
}