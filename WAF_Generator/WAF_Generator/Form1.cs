using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*********************************************
 * 
 * Windows Answer File Generator
 * Made by Sebi
 * Last Update: 15.06.2021
 * Version: 1.0.0
 * 
 * *********************************************/

namespace WAF_Generator
{
    public partial class Form1 : Form
    {
        // Global Variables
        int i = 1; // Current Page Number ( 1 because starting at page 1)
        int imax = 6; // All Pages

        public Form1()
        {
            InitializeComponent();
            this.Text = "Windows Answer File Generator";
            this.Size = new Size(550, 390);
            page.Text = i + " / " + imax;
            general_settings_hr.Location = new Point(12, 9);
            product_key_lb.Location = new Point(75, 67);
            prod_1.Location = new Point(149, 64);
            bind1.Location = new Point(204, 67);
            prod_2.Location = new Point(220, 64);
            bind2.Location = new Point(275, 67);
            prod_3.Location = new Point(291, 64);
            bind3.Location = new Point(346, 67);
            prod_4.Location = new Point(362, 64);
            bind4.Location = new Point(417, 67);
            prod_5.Location = new Point(433, 64);
            accept_eula_lb.Location = new Point(75, 100);
            eula_dd.Location = new Point(149, 97);
            skip_automatic_activation_lb.Location = new Point(14, 137);
            skip_automatic_activation_dd.Location = new Point(149, 134);
            skip_license_rearm_lb.Location = new Point(38, 173);
            skip_license_rearm_dd.Location = new Point(149, 170);
            setup_language_lb.Location = new Point(54, 205);
            setup_language_dd.Location = new Point(149, 202);
            computername_lb.Location = new Point(57, 238);
            computername.Location = new Point(149, 235);
            random.Location = new Point(285, 235);
            organisationname_lb.Location = new Point(43, 272);
            organisationname.Location = new Point(149, 269);
            edit_organisationname.Location = new Point(285, 269);
            next.Location = new Point(443, 305);
            back.Location = new Point(362, 305);
            page.Location = new Point(13, 308);
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            // Set Default's
            eula_dd.SelectedItem = "Yes";
            eula_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            setup_language_dd.SelectedItem = "English";
            setup_language_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            skip_automatic_activation_dd.SelectedItem = "Yes";
            skip_automatic_activation_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            skip_license_rearm_dd.SelectedItem = "Yes";
            skip_license_rearm_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            group_dd.SelectedItem = "Administrators";
            group_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            password_expires_dd.SelectedItem = "False";
            password_expires_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            auto_logon_dd.SelectedItem = "Yes";
            auto_logon_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            uac_dd.SelectedItem = "Disabled";
            uac_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            ceip_dd.SelectedItem = "Disabled";
            ceip_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            wipe_disk_dd.SelectedItem = "Yes";
            wipe_disk_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            Install_to_disk_dd.SelectedItem = "0";
            Install_to_disk_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            main_partition_active_dd.SelectedItem = "Yes";
            main_partition_active_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            main_partition_format_dd.SelectedItem = "NTFS";
            main_partition_format_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            main_partition_letter_dd.SelectedItem = "C";
            main_partition_letter_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            partition_order_dd.SelectedItem = "4";
            partition_order_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            network_location_dd.SelectedItem = "Work";
            network_location_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            express_settings_dd.SelectedItem = "On";
            express_settings_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            hide_eula_dd.SelectedItem = "Yes";
            hide_eula_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            disable_auto_daylight_timeset_dd.SelectedItem = "No";
            disable_auto_daylight_timeset_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            hide_wireless_setup_in_oobe_dd.SelectedItem = "Yes";
            hide_wireless_setup_in_oobe_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            skip_machine_oobe_dd.SelectedItem = "Yes";
            skip_machine_oobe_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            skip_user_oobe_dd.SelectedItem = "Yes";
            skip_user_oobe_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            control_panel_view_dd.SelectedItem = "Classic View";
            control_panel_view_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            control_panel_icon_size_dd.SelectedItem = "Large";
            control_panel_icon_size_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            keyboard_or_input_method_dd.SelectedItem = "English - United States";
            keyboard_or_input_method_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            currency_and_date_format_dd.SelectedItem = "English - United States";
            currency_and_date_format_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            timezone_dd.SelectedItem = "(UTC-06:00) Central Time (US & Canada)";
            timezone_dd.DropDownStyle = ComboBoxStyle.DropDownList;
            ui_language_dd.SelectedItem = "English - United States";
            ui_language_dd.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        private void prod_1_TextChanged(object sender, EventArgs e)
        {
            if (prod_1.TextLength == 5)
            {
                prod_2.Focus();
            }
        }

        private void prod_2_TextChanged(object sender, EventArgs e)
        {
            if (prod_2.TextLength == 5)
            {
                prod_3.Focus();
            }

            if (prod_2.TextLength == 0)
            {
                prod_1.Focus();
            }
        }

        private void prod_3_TextChanged(object sender, EventArgs e)
        {
            if (prod_3.TextLength == 5)
            {
                prod_4.Focus();
            }

            if (prod_3.TextLength == 0)
            {
                prod_2.Focus();
            }
        }

        private void prod_4_TextChanged(object sender, EventArgs e)
        {
            if (prod_4.TextLength == 5)
            {
                prod_5.Focus();
            }

            if (prod_4.TextLength == 0)
            {
                prod_3.Focus();
            }
        }

        private void prod_5_TextChanged(object sender, EventArgs e)
        {
            if (prod_5.TextLength == 0)
            {
                prod_4.Focus();
            }
        }

        private void edit_organisationname_Click(object sender, EventArgs e)
        {
            bool y = organisationname.Enabled;
            organisationname.Enabled = !y;

            if (!y)
            {
                edit_organisationname.Text = "Lock";
            }
            else
            {
                edit_organisationname.Text = "Edit";
            }
        }


        private void next_Click(object sender, EventArgs e)
        {
            if (next.Text == "Generate" || next.Text == "Save")
            {
                // autounattend.xml

                // Displays a SaveFileDialog so the user can save the Image
                // assigned to the button.
                SaveFileDialog Generate = new SaveFileDialog();
                Generate.Filter = "XML-File | *.xml";
                Generate.DefaultExt = "xml";
                Generate.Title = "Save generated Answer File";
                Generate.FileName = "autounattend";

                if (Generate.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(Generate.OpenFile()))
                    {
                        sw.Write(debug.Text);
                        MessageBox.Show("Successfully Saved");
                    }
                }
                return;
            }


            next.Enabled = false;
            back.Enabled = false;

            if (prod_1.TextLength != 5 || prod_2.TextLength != 5 || prod_3.TextLength != 5 || prod_4.TextLength != 5 || prod_5.TextLength != 5)
            {
                MessageBox.Show("Invalid Product Key!");
                prod_1.Focus();
                next.Enabled = true;
                return;
            }

            i++;
            switch (i)
            {
                case 2:
                    // Sync Title
                    this.Text = "Windows Answer File Generator - " + computername.Text + " / " + organisationname.Text;

                    // Unload Page 1
                    general_settings_hr.Visible = false;
                    random.Visible = false;
                    bind1.Visible = false;
                    bind2.Visible = false;
                    bind3.Visible = false;
                    bind4.Visible = false;
                    product_key_lb.Visible = false;
                    accept_eula_lb.Visible = false;
                    skip_automatic_activation_lb.Visible = false;
                    skip_license_rearm_lb.Visible = false;
                    setup_language_lb.Visible = false;
                    computername_lb.Visible = false;
                    organisationname_lb.Visible = false;
                    prod_1.Visible = false;
                    prod_2.Visible = false;
                    prod_3.Visible = false;
                    prod_4.Visible = false;
                    prod_5.Visible = false;
                    computername.Visible = false;
                    organisationname.Visible = false;
                    eula_dd.Visible = false;
                    skip_automatic_activation_dd.Visible = false;
                    skip_license_rearm_dd.Visible = false;
                    setup_language_dd.Visible = false;
                    edit_organisationname.Visible = false;

                    // Load Page 2
                    back.Visible = true;
                    regional_settings_hr.Visible = true;
                    keyboard_or_input_method_lb.Visible = true;
                    currency_and_date_format_lb.Visible = true;
                    timezone_lb.Visible = true;
                    ui_language_lb.Visible = true;
                    keyboard_or_input_method_dd.Visible = true;
                    currency_and_date_format_dd.Visible = true;
                    timezone_dd.Visible = true;
                    ui_language_dd.Visible = true;
                    tmp_german.Visible = true;
                    tmp_english.Visible = true;
                    tmp_german.Location = new Point(183, 305);
                    tmp_english.Location = new Point(252, 305);
                    regional_settings_hr.Location = new Point(12, 9);
                    keyboard_or_input_method_lb.Location = new Point(23, 65);
                    currency_and_date_format_lb.Location = new Point(23, 103);
                    timezone_lb.Location = new Point(93, 145);
                    ui_language_lb.Location = new Point(82, 189);
                    keyboard_or_input_method_dd.Location = new Point(160, 62);
                    currency_and_date_format_dd.Location = new Point(160, 100);
                    timezone_dd.Location = new Point(160, 142);
                    ui_language_dd.Location = new Point(160, 186);

                    // Set Page Number
                    page.Text = i.ToString() + " / " + imax;
                    break;

                case 3:
                    // Unload Page 2
                    regional_settings_hr.Visible = false;
                    keyboard_or_input_method_lb.Visible = false;
                    currency_and_date_format_lb.Visible = false;
                    timezone_lb.Visible = false;
                    ui_language_lb.Visible = false;
                    keyboard_or_input_method_dd.Visible = false;
                    currency_and_date_format_dd.Visible = false;
                    timezone_dd.Visible = false;
                    ui_language_dd.Visible = false;
                    tmp_german.Visible = false;
                    tmp_english.Visible = false;

                    // Load Page 3
                    oobe_hr.Visible = true;
                    network_location_lb.Visible = true;
                    express_settings_lb.Visible = true;
                    hide_eula_lb.Visible = true;
                    disable_auto_daylight_timeset_lb.Visible = true;
                    hide_wireless_setup_in_oobe_lb.Visible = true;
                    skip_machine_oobe_lb.Visible = true;
                    skip_user_oobe_lb.Visible = true;
                    control_panel_view_lb.Visible = true;
                    control_panel_icon_size_lb.Visible = true;
                    network_location_dd.Visible = true;
                    express_settings_dd.Visible = true;
                    hide_eula_dd.Visible = true;
                    disable_auto_daylight_timeset_dd.Visible = true;
                    hide_wireless_setup_in_oobe_dd.Visible = true;
                    skip_machine_oobe_dd.Visible = true;
                    skip_user_oobe_dd.Visible = true;
                    control_panel_view_dd.Visible = true;
                    control_panel_icon_size_dd.Visible = true;
                    oobe_hr.Location = new Point(12, 9);
                    network_location_lb.Location = new Point(62, 49);
                    express_settings_lb.Location = new Point(68, 76);
                    hide_eula_lb.Location = new Point(66, 103);
                    disable_auto_daylight_timeset_lb.Location = new Point(13, 130);
                    hide_wireless_setup_in_oobe_lb.Location = new Point(11, 157);
                    skip_machine_oobe_lb.Location = new Point(49, 184);
                    skip_user_oobe_lb.Location = new Point(69, 211);
                    control_panel_view_lb.Location = new Point(57, 238);
                    control_panel_icon_size_lb.Location = new Point(36, 265);
                    network_location_dd.Location = new Point(162, 46);
                    express_settings_dd.Location = new Point(162, 73);
                    hide_eula_dd.Location = new Point(162, 100);
                    disable_auto_daylight_timeset_dd.Location = new Point(162, 127);
                    hide_wireless_setup_in_oobe_dd.Location = new Point(161, 154);
                    skip_machine_oobe_dd.Location = new Point(162, 181);
                    skip_user_oobe_dd.Location = new Point(162, 208);
                    control_panel_view_dd.Location = new Point(162, 235);
                    control_panel_icon_size_dd.Location = new Point(162, 262);

                    // Set Page Number
                    page.Text = i.ToString() + " / " + imax;
                    break;

                case 4:
                    // Unload Page 3
                    oobe_hr.Visible = false;
                    network_location_lb.Visible = false;
                    express_settings_lb.Visible = false;
                    hide_eula_lb.Visible = false;
                    disable_auto_daylight_timeset_lb.Visible = false;
                    hide_wireless_setup_in_oobe_lb.Visible = false;
                    skip_machine_oobe_lb.Visible = false;
                    skip_user_oobe_lb.Visible = false;
                    control_panel_view_lb.Visible = false;
                    control_panel_icon_size_lb.Visible = false;
                    network_location_dd.Visible = false;
                    express_settings_dd.Visible = false;
                    hide_eula_dd.Visible = false;
                    disable_auto_daylight_timeset_dd.Visible = false;
                    hide_wireless_setup_in_oobe_dd.Visible = false;
                    skip_machine_oobe_dd.Visible = false;
                    skip_user_oobe_dd.Visible = false;
                    control_panel_view_dd.Visible = false;
                    control_panel_icon_size_dd.Visible = false;

                    // Load Page 4
                    partition_settings_hr.Visible = true;
                    wipe_disk_lb.Visible = true;
                    Install_to_disk_lb.Visible = true;
                    main_partition_active_lb.Visible = true;
                    main_partition_format_lb.Visible = true;
                    main_partition_label_lb.Visible = true;
                    main_partitio_letter_lb.Visible = true;
                    partition_order_lb.Visible = true;
                    wipe_disk_dd.Visible = true;
                    Install_to_disk_dd.Visible = true;
                    main_partition_active_dd.Visible = true;
                    main_partition_format_dd.Visible = true;
                    main_partition_label.Visible = true;
                    main_partition_letter_dd.Visible = true;
                    partition_order_dd.Visible = true;
                    partition_settings_hr.Location = new Point(12, 9);
                    wipe_disk_lb.Location = new Point(107, 65);
                    Install_to_disk_lb.Location = new Point(89, 92);
                    main_partition_active_lb.Location = new Point(59, 121);
                    main_partition_format_lb.Location = new Point(57, 146);
                    main_partition_label_lb.Location = new Point(63, 173);
                    main_partitio_letter_lb.Location = new Point(67, 200);
                    partition_order_lb.Location = new Point(89, 227);
                    wipe_disk_dd.Location = new Point(172, 62);
                    Install_to_disk_dd.Location = new Point(172, 89);
                    main_partition_active_dd.Location = new Point(172, 116);
                    main_partition_format_dd.Location = new Point(172, 143);
                    main_partition_label.Location = new Point(172, 171);
                    main_partition_letter_dd.Location = new Point(172, 197);
                    partition_order_dd.Location = new Point(172, 224);

                    // Set Page Number
                    page.Text = i.ToString() + " / " + imax;
                    break;

                case 5:
                    // Unload Page 4
                    partition_settings_hr.Visible = false;
                    wipe_disk_lb.Visible = false;
                    Install_to_disk_lb.Visible = false;
                    main_partition_active_lb.Visible = false;
                    main_partition_format_lb.Visible = false;
                    main_partition_label_lb.Visible = false;
                    main_partitio_letter_lb.Visible = false;
                    partition_order_lb.Visible = false;
                    wipe_disk_dd.Visible = false;
                    Install_to_disk_dd.Visible = false;
                    main_partition_active_dd.Visible = false;
                    main_partition_format_dd.Visible = false;
                    main_partition_label.Visible = false;
                    main_partition_letter_dd.Visible = false;
                    partition_order_dd.Visible = false;

                    // Load Page 5
                    user_account_hr.Visible = true;
                    user_name_lb.Visible = true;
                    group_lb.Visible = true;
                    description_lb.Visible = true;
                    opt_password_lb.Visible = true;
                    password_expires_lb.Visible = true;
                    auto_logon_lb.Visible = true;
                    uac_lb.Visible = true;
                    ceip_lb.Visible = true;
                    user_name.Visible = true;
                    group_dd.Visible = true;
                    description.Visible = true;
                    opt_password.Visible = true;
                    password_expires_dd.Visible = true;
                    auto_logon_dd.Visible = true;
                    uac_dd.Visible = true;
                    ceip_dd.Visible = true;
                    user_account_hr.Location = new Point(12, 9);
                    user_name_lb.Location = new Point(103, 65);
                    group_lb.Location = new Point(127, 92);
                    description_lb.Location = new Point(103, 121);
                    opt_password_lb.Location = new Point(64, 190);
                    password_expires_lb.Location = new Point(73, 216);
                    auto_logon_lb.Location = new Point(101, 244);
                    uac_lb.Location = new Point(336, 65);
                    ceip_lb.Location = new Point(334, 92);
                    user_name.Location = new Point(172, 62);
                    group_dd.Location = new Point(172, 89);
                    description.Location = new Point(172, 118);
                    opt_password.Location = new Point(172, 187);
                    password_expires_dd.Location = new Point(172, 213);
                    auto_logon_dd.Location = new Point(172, 241);
                    uac_dd.Location = new Point(374, 61);
                    ceip_dd.Location = new Point(374, 88);

                    // Set Page Number
                    page.Text = i.ToString() + " / " + imax;
                    break;

                case 6:
                    // Unload Page 5
                    user_account_hr.Visible = false;
                    user_name_lb.Visible = false;
                    group_lb.Visible = false;
                    description_lb.Visible = false;
                    opt_password_lb.Visible = false;
                    password_expires_lb.Visible = false;
                    auto_logon_lb.Visible = false;
                    uac_lb.Visible = false;
                    ceip_lb.Visible = false;
                    user_name.Visible = false;
                    group_dd.Visible = false;
                    description.Visible = false;
                    opt_password.Visible = false;
                    password_expires_dd.Visible = false;
                    auto_logon_dd.Visible = false;
                    uac_dd.Visible = false;
                    ceip_dd.Visible = false;

                    // Load Page 6
                    showcode.Checked = false;
                    showcode.Visible = true;
                    debug.Visible = false;
                    confirmation.Visible = true;
                    confirmation.Location = new Point(12, 12);
                    debug.Location = new Point(12, 12);
                    showcode.Location = new Point(275, 305);


                    // Set Page Number
                    page.Text = i.ToString() + " / " + imax;
                    break;

                default:
                    MessageBox.Show("Page " + i + " either doesn't exist or isn't labeled in the range of the Index!");
                    i--;
                    break;
            }

            // Save from Next Spam
            next.Enabled = true;
            back.Enabled = true;

            if (i == 6) // 6 = The Page with the Overview
            {
                // Information:
                var CreatedBy = Environment.UserName;
                var Domain = Environment.UserDomainName;
                var Time = DateTime.Now.ToString();

                // User Input:
                var prodkey = prod_1.Text + "-" + prod_2.Text + "-" + prod_3.Text + "-" + prod_4.Text + "-" + prod_5.Text;
                var pcname = computername.Text;
                var orgname = organisationname.Text;
                var eula = eula_dd.Text;
                var skip_automatic_activation = skip_automatic_activation_dd.Text;
                var skip_license_rearm = skip_license_rearm_dd.Text;
                var setup_lang = setup_language_dd.Text;
                //
                var input = keyboard_or_input_method_dd.Text;
                var currency_time = currency_and_date_format_dd.Text;
                var timezone = timezone_dd.Text;
                var UIL = ui_language_dd.Text;
                //
                var networklocation = network_location_dd.Text;
                var express = express_settings_dd.Text;
                var eulapage = hide_eula_dd.Text;
                var daylight_timeset = disable_auto_daylight_timeset_dd.Text;
                var wireless_oobe = hide_wireless_setup_in_oobe_dd.Text;
                var machine_oobe = skip_machine_oobe_dd.Text;
                var user_oobe = skip_user_oobe_dd.Text;
                var control_panel_view = control_panel_view_dd.Text;
                var control_icon = control_panel_icon_size_dd.Text;
                //
                var wipe_disk = wipe_disk_dd.Text;
                var install_to_disk = Install_to_disk_dd.Text;
                var mp_active = main_partition_active_dd.Text;
                var mp_format = main_partition_format_dd.Text;
                var mp_label = main_partition_label.Text;
                var mp_letter = main_partition_letter_dd.Text;
                var partition_order = partition_order_dd.Text;
                //
                var username = user_name.Text;
                var group = group_dd.Text;
                var desc = description.Text;
                var optpwd = opt_password.Text;
                var expires = password_expires_dd.Text.ToLower();
                var logon = auto_logon_dd.Text;
                var uac = uac_dd.Text;
                var ceip = ceip_dd.Text;


                //Hier zur Confirmation alles einfügen
                confirmation.Text = "";
                confirmation.AppendText(System.Environment.NewLine + "--------------------------------------------------------------------");
                confirmation.AppendText(System.Environment.NewLine + "");
                confirmation.AppendText(System.Environment.NewLine + "Product Key: " + prodkey);
                confirmation.AppendText(System.Environment.NewLine + "Name of PC: " + pcname);
                confirmation.AppendText(System.Environment.NewLine + "Organisation: " + orgname);
                confirmation.AppendText(System.Environment.NewLine + "Accept Eula: " + eula);
                confirmation.AppendText(System.Environment.NewLine + "Skip automatic activation: " + skip_automatic_activation);
                confirmation.AppendText(System.Environment.NewLine + "Skip License Rearm: " + skip_license_rearm);
                confirmation.AppendText(System.Environment.NewLine + "Setup Language: " + setup_lang);
                confirmation.AppendText(System.Environment.NewLine + "");
                confirmation.AppendText(System.Environment.NewLine + "--------------------------------------------------------------------");
                confirmation.AppendText(System.Environment.NewLine + "");
                confirmation.AppendText(System.Environment.NewLine + "Keyboard or input Method: " + input);
                confirmation.AppendText(System.Environment.NewLine + "Currency and Date format: " + currency_time);
                confirmation.AppendText(System.Environment.NewLine + "Timezone: " + timezone);
                confirmation.AppendText(System.Environment.NewLine + "UI Language: " + UIL);
                confirmation.AppendText(System.Environment.NewLine + "");
                confirmation.AppendText(System.Environment.NewLine + "--------------------------------------------------------------------");
                confirmation.AppendText(System.Environment.NewLine + "");
                confirmation.AppendText(System.Environment.NewLine + "Network Location: " + networklocation);
                confirmation.AppendText(System.Environment.NewLine + "Express Settings: " + express);
                confirmation.AppendText(System.Environment.NewLine + "Hide EULA Page: " + eulapage);
                confirmation.AppendText(System.Environment.NewLine + "Disable auto Daylight Tmeset: " + daylight_timeset);
                confirmation.AppendText(System.Environment.NewLine + "Hide Wireless Setup in OOBE: " + wireless_oobe);
                confirmation.AppendText(System.Environment.NewLine + "Skip Machine OOBE: " + machine_oobe);
                confirmation.AppendText(System.Environment.NewLine + "Skip User OOBE: " + user_oobe);
                confirmation.AppendText(System.Environment.NewLine + "Control Panel View: " + control_panel_view);
                confirmation.AppendText(System.Environment.NewLine + "Control Panel Icon Size: " + control_icon);
                confirmation.AppendText(System.Environment.NewLine + "");
                confirmation.AppendText(System.Environment.NewLine + "--------------------------------------------------------------------");
                confirmation.AppendText(System.Environment.NewLine + "");
                confirmation.AppendText(System.Environment.NewLine + "Wipe Disk: " + wipe_disk);
                confirmation.AppendText(System.Environment.NewLine + "Install to Disk: " + install_to_disk);
                confirmation.AppendText(System.Environment.NewLine + "Main Partition Active: " + mp_active);
                confirmation.AppendText(System.Environment.NewLine + "Main Partition Format: " + mp_format);
                confirmation.AppendText(System.Environment.NewLine + "Main Partition Label: " + mp_label);
                confirmation.AppendText(System.Environment.NewLine + "Main Partition Letter: " + mp_letter);
                confirmation.AppendText(System.Environment.NewLine + "Partition Order: " + partition_order);
                confirmation.AppendText(System.Environment.NewLine + "");
                confirmation.AppendText(System.Environment.NewLine + "--------------------------------------------------------------------");
                confirmation.AppendText(System.Environment.NewLine + "");
                confirmation.AppendText(System.Environment.NewLine + "Username: " + username);
                confirmation.AppendText(System.Environment.NewLine + "Group: " + group);
                confirmation.AppendText(System.Environment.NewLine + "Desscription: " + desc);
                confirmation.AppendText(System.Environment.NewLine + "Password (optional): " + optpwd);
                confirmation.AppendText(System.Environment.NewLine + "Password Expires: " + expires);
                confirmation.AppendText(System.Environment.NewLine + "Auto Logon: " + logon);
                confirmation.AppendText(System.Environment.NewLine + "UAC: " + uac);
                confirmation.AppendText(System.Environment.NewLine + "CEIP: " + ceip);
                confirmation.AppendText(System.Environment.NewLine + "");
                confirmation.AppendText(System.Environment.NewLine + "--------------------------------------------------------------------");
                confirmation.AppendText(System.Environment.NewLine + "");


                var languageUI = "en-US"; // English United Kingdom

                if (setup_lang == "English")
                {
                    languageUI = "en-US";
                }

                else if (setup_lang == "French")
                {
                    languageUI = "fr-FR";
                }

                else if (setup_lang == "German")
                {
                    languageUI = "de-DE";
                }

                else if (setup_lang == "Spanish")
                {
                    languageUI = "es-ES";
                }

                else if (setup_lang == "Dutch")
                {
                    languageUI = "nl-NL";
                }

                else if (setup_lang == "Italian")
                {
                    languageUI = "it-IT";
                }

                else if (setup_lang == "Russian")
                {
                    languageUI = "ru-RU";
                }

                else if (setup_lang == "Japanese")
                {
                    languageUI = "ja-JP";
                }

                else if (setup_lang == "Arabic")
                {
                    languageUI = "ar-SA";
                }

                else if (setup_lang == "Czech")
                {
                    languageUI = "cs-CZ";
                }

                else if (setup_lang == "Danish")
                {
                    languageUI = "da-DK";
                }

                else if (setup_lang == "Greek")
                {
                    languageUI = "el-GR";
                }

                else if (setup_lang == "Swedish")
                {
                    languageUI = "sv-SE";
                }

                else if (setup_lang == "Portuguese (BR)")
                {
                    languageUI = "pt-BR";
                }

                else if (setup_lang == "Portuguese (PT)")
                {
                    languageUI = "pt-PT";
                }

                else
                {
                    MessageBox.Show("Error Setting language UI Variable. Please Contact an Administrator!");
                    MessageBox.Show("Using " + languageUI + " as UI Language");
                }


                var inputlocale = "0409:00000409"; // English United Kingdom

                if (input == "Afrikaans - South Africa")
                {
                    inputlocale = "0436:00000409";
                }

                else if (input == "Arabic - Bahrain")
                {
                    inputlocale = "3c01:00000401";
                }

                else if (input == "Arabic - Egypt")
                {
                    inputlocale = "0c01:00000401";
                }

                else if (input == "Arabic - Iraq")
                {
                    inputlocale = "0801:00000401";
                }

                else if (input == "Arabic - Jordan")
                {
                    inputlocale = "2c01:00000401";
                }

                else if (input == "Arabic - Kuwait")
                {
                    inputlocale = "3401:00000401";
                }

                else if (input == "Arabic - Lebanon")
                {
                    inputlocale = "3001:00000401";
                }

                else if (input == "Arabic - Morocco")
                {
                    inputlocale = "1801:00020401";
                }

                else if (input == "Arabic - Oman")
                {
                    inputlocale = "2001:00000401";
                }

                else if (input == "Arabic - Qatar")
                {
                    inputlocale = "4001:00000401";
                }

                else if (input == "Arabic - Saudi Arabia")
                {
                    inputlocale = "0401:00000401";
                }

                else if (input == "Arabic - Syria")
                {
                    inputlocale = "2801:00000401";
                }

                else if (input == "Arabic - Tunisia")
                {
                    inputlocale = "1c01:00020401";
                }

                else if (input == "Arabic - U.A.E.")
                {
                    inputlocale = "3801:00000401";
                }

                else if (input == "Arabic - Yemen")
                {
                    inputlocale = "2401:00000401";
                }

                else if (input == "Armenian - Armenia")
                {
                    inputlocale = "042b:0002042b";
                }

                else if (input == "Assamese - India")
                {
                    inputlocale = "044d:0000044d";
                }

                else if (input == "Azerbaijani - Azerbaijan (Cyrillic)")
                {
                    inputlocale = "082c:0000082c";
                }

                else if (input == "Azerbaijani - Azerbaijan (Latin)")
                {
                    inputlocale = "042c:0000042c";
                }

                else if (input == "Bangla - Bangladesh")
                {
                    inputlocale = "0845:00000445";
                }

                else if (input == "Bangla - India (Bengali Script)")
                {
                    inputlocale = "0445:00020445";
                }

                else if (input == "Bashkir - Russia")
                {
                    inputlocale = "046d:0000046d";
                }

                else if (input == "Basque - Basque")
                {
                    inputlocale = "042d:0000040a";
                }

                else if (input == "Belarusian - Belarus")
                {
                    inputlocale = "0423:00000423";
                }

                else if (input == "Bosnian - Bosnia and Herzegovina (Cyrillic)")
                {
                    inputlocale = "201a:0000201a";
                }

                else if (input == "Bosnian - Bosnia and Herzegovina (Latin)")
                {
                    inputlocale = "141a:0000041a";
                }

                else if (input == "Breton - France")
                {
                    inputlocale = "047e:0000040c";
                }

                else if (input == "Bulgarian - Bulgaria")
                {
                    inputlocale = "0402:00030402";
                }

                else if (input == "Catalan - Catalan")
                {
                    inputlocale = "0403:0000040a";
                }

                else if (input == "Central Atlas Tamazight (Latin) - Algeria")
                {
                    inputlocale = "040c:0000040c";
                }

                else if (input == "Central Atlas Tamazight (Tifinagh) - Morocco")
                {
                    inputlocale = "105f:0000105f";
                }

                else if (input == "Central Kurdish (Iraq)")
                {
                    inputlocale = "0492:00000492";
                }

                else if (input == "Cherokee (Cherokee, United States)")
                {
                    inputlocale = "045c:0000045c";
                }

                else if (input == "Chinese - Hong Kong")
                {
                    inputlocale = "0c01:00000401";
                }

                else if (input == "Arabic - Egypt")
                {
                    inputlocale = "0404:{531FDEBF-9B4C-4A43-A2AA-960E8FCDC732}{6024B45F-5C54-11D4-B921-0080C882687E}";
                }

                else if (input == "Chinese - Macao")
                {
                    inputlocale = "0404:{531FDEBF-9B4C-4A43-A2AA-960E8FCDC732}{6024B45F-5C54-11D4-B921-0080C882687E";
                }

                else if (input == "Chinese - PRC")
                {
                    inputlocale = "0804:{81D4E9C9-1D3B-41BC-9E6C-4B40BF79E35E}{FA550B04-5AD7-411f-A5AC-CA038EC515D7}";
                }

                else if (input == "Chinese - Singapore")
                {
                    inputlocale = "0804:{81D4E9C9-1D3B-41BC-9E6C-4B40BF79E35E}{FA550B04-5AD7-411f-A5AC-CA038EC515D7}";
                }

                else if (input == "Chinese - Taiwan")
                {
                    inputlocale = "0404:{531FDEBF-9B4C-4A43-A2AA-960E8FCDC732}{B2F9C502-1742-11D4-9790-0080C882687E}";
                }

                else if (input == "Corsican - France")
                {
                    inputlocale = "0483:0000040c";
                }

                else if (input == "Croatian - Bosnia and Herzegovina")
                {
                    inputlocale = "101a:0000041a";
                }

                else if (input == "Croatian - Croatia")
                {
                    inputlocale = "041a:0000041a";
                }

                else if (input == "Czech - Czech Republic")
                {
                    inputlocale = "0405:00000405";
                }

                else if (input == "Danish - Denmark")
                {
                    inputlocale = "0406:00000406";
                }

                else if (input == "Dari - Afghanistan")
                {
                    inputlocale = "048c:00050429";
                }

                else if (input == "Divehi - Maldives")
                {
                    inputlocale = "0465:00000465";
                }

                else if (input == "Dutch - Belgium")
                {
                    inputlocale = "0813:00000813";
                }

                else if (input == "Dutch - Netherlands")
                {
                    inputlocale = "0413:00020409";
                }

                else if (input == "English - Australia")
                {
                    inputlocale = "0c09:00000409";
                }

                else if (input == "English - Belize")
                {
                    inputlocale = "2809:00000409";
                }

                else if (input == "English - Canada")
                {
                    inputlocale = "1009:00000409";
                }

                else if (input == "English - Caribbean")
                {
                    inputlocale = "2409:00000409";
                }

                else if (input == "English - India")
                {
                    inputlocale = "4009:00004009";
                }

                else if (input == "English - Ireland")
                {
                    inputlocale = "1809:00001809";
                }

                else if (input == "English - Jamaica")
                {
                    inputlocale = "2009:00000409";
                }

                else if (input == "English - Malaysia")
                {
                    inputlocale = "4409:00000409";
                }

                else if (input == "English - New Zealand")
                {
                    inputlocale = "1409:00000409";
                }

                else if (input == "English - Philippines")
                {
                    inputlocale = "3409:00000409";
                }

                else if (input == "English - Singapore")
                {
                    inputlocale = "4809:00000409";
                }

                else if (input == "English - South Africa")
                {
                    inputlocale = "1c09:00000409";
                }

                else if (input == "English - Trinidad")
                {
                    inputlocale = "2c09:00000409";
                }

                else if (input == "English - United Kingdom")
                {
                    inputlocale = "0809:00000809";
                }

                else if (input == "English - United States")
                {
                    inputlocale = "0409:00000409";
                }

                else if (input == "English - Zimbabwe")
                {
                    inputlocale = "3009:00000409";
                }

                else if (input == "Estonian - Estonia")
                {
                    inputlocale = "0425:00000425";
                }

                else if (input == "Faroese - Faroe Islands")
                {
                    inputlocale = "0438:00000406";
                }

                else if (input == "Filipino - Philippines")
                {
                    inputlocale = "0464:00000409";
                }

                else if (input == "Finnish - Finland")
                {
                    inputlocale = "040b:0000040b";
                }

                else if (input == "French - Belgium")
                {
                    inputlocale = "080c:0000080c";
                }

                else if (input == "French - Canada")
                {
                    inputlocale = "0c0c:00011009";
                }

                else if (input == "French - France")
                {
                    inputlocale = "040c:0000040c";
                }

                else if (input == "French - Luxembourg")
                {
                    inputlocale = "140c:0000100C";
                }

                else if (input == "French - Monaco")
                {
                    inputlocale = "180c:0000040c";
                }

                else if (input == "French - Switzerland")
                {
                    inputlocale = "100c:0000100c";
                }

                else if (input == "Frisian - Netherlands")
                {
                    inputlocale = "0462:00020409";
                }

                else if (input == "Fulah (Latin, Senegal)")
                {
                    inputlocale = "0867:00000488";
                }

                else if (input == "Galician - Galician")
                {
                    inputlocale = "0456:0000040a";
                }

                else if (input == "Georgian - Georgia")
                {
                    inputlocale = "0437:00010437";
                }

                else if (input == "German - Austria")
                {
                    inputlocale = "0c07:00000407";
                }

                else if (input == "German - Germany")
                {
                    inputlocale = "0407:00000407";
                }

                else if (input == "German - Liechtenstein")
                {
                    inputlocale = "1407:00000807";
                }

                else if (input == "German - Luxembourg")
                {
                    inputlocale = "1007:00000407";
                }

                else if (input == "German - Switzerland")
                {
                    inputlocale = "0807:00000807";
                }

                else if (input == "Greek - Greece")
                {
                    inputlocale = "0408:00000408";
                }

                else if (input == "Greenlandic - Greenland")
                {
                    inputlocale = "046f:00000406";
                }

                else if (input == "Gujarati - India (Gujarati Script)")
                {
                    inputlocale = "0447:00000447";
                }

                else if (input == "Hausa (Latin) - Nigeria")
                {
                    inputlocale = "0468:00000468";
                }

                else if (input == "Hawaiian - United States")
                {
                    inputlocale = "0475:00000475";
                }

                else if (input == "Hebrew - Israel")
                {
                    inputlocale = "040d:0002040d";
                }

                else if (input == "Hindi - India")
                {
                    inputlocale = "0439:00010439";
                }

                else if (input == "Hungarian - Hungary")
                {
                    inputlocale = "040e:0000040e";
                }

                else if (input == "Icelandic - Iceland")
                {
                    inputlocale = "040f:0000040f";
                }

                else if (input == "Igbo - Nigeria")
                {
                    inputlocale = "0470:00000470";
                }

                else if (input == "Inari Sami - Finland")
                {
                    inputlocale = "243b:0001083b";
                }

                else if (input == "Indonesian - Indonesia")
                {
                    inputlocale = "0421:00000409";
                }

                else if (input == "Inuktitut (Latin) - Canada")
                {
                    inputlocale = "085d:0000085d";
                }

                else if (input == "Inuktitut (Syllabics) - Canada")
                {
                    inputlocale = "045d:0001045d";
                }

                else if (input == "Irish - Ireland")
                {
                    inputlocale = "083c:00001809";
                }

                else if (input == "isiXhosa / Xhosa - South Africa")
                {
                    inputlocale = "0434:00000409";
                }

                else if (input == "isiZulu / Zulu - South Africa")
                {
                    inputlocale = "0435:00000409";
                }

                else if (input == "Italian - Italy")
                {
                    inputlocale = "0410:00000410";
                }

                else if (input == "Italian - Switzerland")
                {
                    inputlocale = "0810:0000100c";
                }

                else if (input == "Japanese - Japan")
                {
                    inputlocale = "0411:{03B5835F-F03C-411B-9CE2-AA23E1171E36}{A76C93D9-5523-4E90-AAFA-4DB112F9AC76}";
                }

                else if (input == "Kannada - India (Kannada Script)")
                {
                    inputlocale = "044b:0000044b";
                }

                else if (input == "Kazakh - Kazakhstan")
                {
                    inputlocale = "043f:0000043f";
                }

                else if (input == "Khmer - Cambodia")
                {
                    inputlocale = "0453:00000453";
                }

                else if (input == "K'iche - Guatemala")
                {
                    inputlocale = "0486:0000080a";
                }

                else if (input == "Kinyarwanda - Rwanda")
                {
                    inputlocale = "0487:00000409";
                }

                else if (input == "Konkani - India")
                {
                    inputlocale = "0457:00000439";
                }

                else if (input == "Korean(Extended Wansung) - Korea")
                {
                    inputlocale = "0412:{A028AE76-01B1-46C2-99C4-ACD9858AE02F}{B5FE1F02-D5F2-4445-9C03-C568F23C99A1}";
                }

                else if (input == "Kyrgyz - Kyrgyzstan")
                {
                    inputlocale = "0440:00000440";
                }

                else if (input == "Lao - Lao PDR")
                {
                    inputlocale = "0454:00000454";
                }

                else if (input == "Latvian - Latvia")
                {
                    inputlocale = "0426:00010426";
                }

                else if (input == "Lithuanian - Lithuania")
                {
                    inputlocale = "0427:00010427";
                }

                else if (input == "Lower Sorbian - Germany")
                {
                    inputlocale = "082e:0002042e";
                }

                else if (input == "Lule Sami - Norway")
                {
                    inputlocale = "103b:0000043b";
                }

                else if (input == "Lule Sami - Sweden")
                {
                    inputlocale = "143b:0000083b";
                }

                else if (input == "Luxembourgish - Luxembourg")
                {
                    inputlocale = "046e:0000046e";
                }

                else if (input == "Macedonian - F.Y.R.O.M")
                {
                    inputlocale = "042f:0001042f";
                }

                else if (input == "Malay - Brunei")
                {
                    inputlocale = "083e:00000409";
                }

                else if (input == "Malay - Malaysia")
                {
                    inputlocale = "043e:00000409";
                }

                else if (input == "Malayalam - India (Malayalam Script)")
                {
                    inputlocale = "044c:0000044c";
                }

                else if (input == "Maltese - Malta")
                {
                    inputlocale = "043a:0000043a";
                }

                else if (input == "Maori - New Zealand")
                {
                    inputlocale = "0481:00000481";
                }

                else if (input == "Mapudungun - Chile")
                {
                    inputlocale = "047a:0000080a";
                }

                else if (input == "Marathi - India")
                {
                    inputlocale = "044e:0000044e";
                }

                else if (input == "Mohawk - Mohawk")
                {
                    inputlocale = "047c:00000409";
                }

                else if (input == "Mongolian (Cyrillic) - Mongolia")
                {
                    inputlocale = "0450:00000450";
                }

                else if (input == "Mongolian (Mongolian) - PRC")
                {
                    inputlocale = "0850:00000850";
                }

                else if (input == "Nepali - Nepal")
                {
                    inputlocale = "0461:00000461";
                }

                else if (input == "Northern Sami - Finland")
                {
                    inputlocale = "0c3b:0001083b";
                }

                else if (input == "Northern Sami - Norway")
                {
                    inputlocale = "043b:0000043b";
                }

                else if (input == "Northern Sami - Sweden")
                {
                    inputlocale = "083b:0000083b";
                }

                else if (input == "Norwegian - Norway (Bokmal)")
                {
                    inputlocale = "0414:00000414";
                }

                else if (input == "Norwegian - Norway (Nynorsk)")
                {
                    inputlocale = "0814:00000414";
                }

                else if (input == "Occitan - France")
                {
                    inputlocale = "0482:0000040c";
                }

                else if (input == "Odia - India (Odia Script)")
                {
                    inputlocale = "0448:00000448";
                }

                else if (input == "Pashto - Afghanistan")
                {
                    inputlocale = "0463:00000463";
                }

                else if (input == "Persian")
                {
                    inputlocale = "0429:00000429";
                }

                else if (input == "Polish - Poland")
                {
                    inputlocale = "0415:00000415";
                }

                else if (input == "Portuguese - Brazil")
                {
                    inputlocale = "0416:00000416";
                }

                else if (input == "Portuguese - Portugal")
                {
                    inputlocale = "0816:00000816";
                }

                else if (input == "Punjabi - India (Gurmukhi Script)")
                {
                    inputlocale = "0446:00000446";
                }

                else if (input == "Punjabi (Islamic Republic of Pakistan)")
                {
                    inputlocale = "0846:00000420";
                }

                else if (input == "Quechua - Bolivia")
                {
                    inputlocale = "046b:0000080a";
                }

                else if (input == "Quechua - Ecuador")
                {
                    inputlocale = "086b:0000080a";
                }

                else if (input == "Quechua - Peru")
                {
                    inputlocale = "0c6b:0000080a";
                }

                else if (input == "Romanian - Romania")
                {
                    inputlocale = "0418:00010418";
                }

                else if (input == "Romansh - Switzerland")
                {
                    inputlocale = "0417:00000807";
                }

                else if (input == "Russian - Russia")
                {
                    inputlocale = "0419:00000419";
                }

                else if (input == "Sakha - Russia")
                {
                    inputlocale = "0485:00000485";
                }

                else if (input == "Sanskrit - India")
                {
                    inputlocale = "044f:00000439";
                }

                else if (input == "Scottish Gaelic - United Kingdom")
                {
                    inputlocale = "0491:00011809";
                }

                else if (input == "Serbian - Bosnia and Herzegovina (Cyrillic)")
                {
                    inputlocale = "1c1a:00000c1a";
                }

                else if (input == "Serbian - Bosnia and Herzegovina (Latin)")
                {
                    inputlocale = "181a:0000081a";
                }

                else if (input == "Serbian - Montenegro (Cyrillic)")
                {
                    inputlocale = "301a:00000c1a";
                }

                else if (input == "Serbian - Montenegro (Latin)")
                {
                    inputlocale = "2c1a:0000081a";
                }

                else if (input == "Serbian - Serbia (Cyrillic)")
                {
                    inputlocale = "281a:00000c1a";
                }

                else if (input == "Serbian - Serbia (Latin)")
                {
                    inputlocale = "241a:0000081a";
                }

                else if (input == "Serbian - Serbia and Montenegro (Former) (Cyrillic)")
                {
                    inputlocale = "0c1a:00000c1a";
                }

                else if (input == "Serbian - Serbia and Montenegro (Former) (Latin)")
                {
                    inputlocale = "081a:0000081a";
                }

                else if (input == "Sesotho sa Leboa / Northern Sotho - South Africa")
                {
                    inputlocale = "046c:0000046c";
                }

                else if (input == "Setswana / Tswana - Botswana")
                {
                    inputlocale = "0832:00000432";
                }

                else if (input == "Setswana / Tswana - South Africa")
                {
                    inputlocale = "0432:00000432";
                }

                else if (input == "Sindhi (Islamic Republic of Pakistan)")
                {
                    inputlocale = "0859:00000420";
                }

                else if (input == "Sinhala - Sri Lanka")
                {
                    inputlocale = "045b:0000045b";
                }

                else if (input == "Skolt Sami - Finland")
                {
                    inputlocale = "203b:0001083b";
                }

                else if (input == "Slovak - Slovakia")
                {
                    inputlocale = "041b:0000041b";
                }

                else if (input == "Slovenian - Slovenia")
                {
                    inputlocale = "0424:00000424";
                }

                else if (input == "Southern Sami - Norway")
                {
                    inputlocale = "183b:0000043b";
                }

                else if (input == "Southern Sami - Sweden")
                {
                    inputlocale = "1c3b:0000083b";
                }

                else if (input == "Spanish - Argentina")
                {
                    inputlocale = "2c0a:0000080a";
                }

                else if (input == "Spanish - Bolivarian Republic of Venezuela")
                {
                    inputlocale = "200a:0000080a";
                }

                else if (input == "Spanish - Bolivia")
                {
                    inputlocale = "400a:0000080a";
                }

                else if (input == "Spanish - Chile")
                {
                    inputlocale = "340a:0000080a";
                }

                else if (input == "Spanish - Colombia")
                {
                    inputlocale = "240a:0000080a";
                }

                else if (input == "Spanish - Costa Rica")
                {
                    inputlocale = "140a:0000080a";
                }

                else if (input == "Spanish - Dominican Republic")
                {
                    inputlocale = "1c0a:0000080a";
                }

                else if (input == "Spanish - Ecuador")
                {
                    inputlocale = "300a:0000080a";
                }

                else if (input == "Spanish - El Salvador")
                {
                    inputlocale = "440a:0000080a";
                }

                else if (input == "Spanish - Guatemala")
                {
                    inputlocale = "100a:0000080a";
                }

                else if (input == "Spanish - Honduras")
                {
                    inputlocale = "480a:0000080a";
                }

                else if (input == "Spanish - Mexico")
                {
                    inputlocale = "080a:0000080a";
                }

                else if (input == "Spanish - Nicaragua")
                {
                    inputlocale = "4c0a:0000080a";
                }

                else if (input == "Spanish - Panama")
                {
                    inputlocale = "180a:0000080a";
                }

                else if (input == "Spanish - Paraguay")
                {
                    inputlocale = "3c0a:0000080a";
                }

                else if (input == "Spanish - Peru")
                {
                    inputlocale = "280a:0000080a";
                }

                else if (input == "Spanish - Puerto Rico")
                {
                    inputlocale = "500a:0000080a";
                }

                else if (input == "Spanish - Spain (International Sort)")
                {
                    inputlocale = "0c0a:0000040a";
                }

                else if (input == "Spanish - Spain (Traditional Sort)")
                {
                    inputlocale = "040a:0000040a";
                }

                else if (input == "Spanish - United States")
                {
                    inputlocale = "540a:0000080a";
                }

                else if (input == "Spanish - Uruguay")
                {
                    inputlocale = "380a:0000080a";
                }

                else if (input == "Swahili - Kenya")
                {
                    inputlocale = "0441:00000409";
                }

                else if (input == "Swedish - Finland")
                {
                    inputlocale = "081d:0000041d";
                }

                else if (input == "Swedish - Sweden")
                {
                    inputlocale = "041d:0000041d";
                }

                else if (input == "Syriac - Syria")
                {
                    inputlocale = "045a:0000045a";
                }

                else if (input == "Tajik - Tajikistan")
                {
                    inputlocale = "0428:00000428";
                }

                else if (input == "Tamil - India")
                {
                    inputlocale = "0449:00000449";
                }

                else if (input == "Tamil - Sri Lanka")
                {
                    inputlocale = "0849:00000449";
                }

                else if (input == "Tatar - Russia")
                {
                    inputlocale = "0444:00000444";
                }

                else if (input == "Telugu - India (Telugu Script)")
                {
                    inputlocale = "044a:0000044a";
                }

                else if (input == "Thai - Thailand")
                {
                    inputlocale = "041e:0000041e";
                }

                else if (input == "Tibetan - PRC")
                {
                    inputlocale = "0451:00000451";
                }

                else if (input == "Tigrinya (Eritrea)")
                {
                    inputlocale = "0473:{E429B25A-E5D3-4D1F-9BE3-0C608477E3A1}{3CAB88B7-CC3E-46A6-9765-B772AD7761FF}";
                }

                else if (input == "Tigrinya (Ethiopia)")
                {
                    inputlocale = "0473:{E429B25A-E5D3-4D1F-9BE3-0C608477E3A1}{3CAB88B7-CC3E-46A6-9765-B772AD7761FF}";
                }

                else if (input == "Turkish - Turkey")
                {
                    inputlocale = "041f:0000041f";
                }

                else if (input == "Turkmen - Turkmenistan")
                {
                    inputlocale = "0442:00000442";
                }

                else if (input == "Ukrainian - Ukraine")
                {
                    inputlocale = "0422:00020422";
                }

                else if (input == "Upper Sorbian - Germany")
                {
                    inputlocale = "042e:0002042e";
                }

                else if (input == "Urdu (Islamic Republic of Pakistan)")
                {
                    inputlocale = "0420:00000420";
                }

                else if (input == "Uyghur - PRC")
                {
                    inputlocale = "0480:00010480";
                }

                else if (input == "Uzbek - Uzbekistan (Cyrillic)")
                {
                    inputlocale = "0843:00000843";
                }

                else if (input == "Uzbek - Uzbekistan (Latin)")
                {
                    inputlocale = "0443:00000409";
                }

                else if (input == "Valencian - Valencia")
                {
                    inputlocale = "0803:0000040a";
                }

                else if (input == "Welsh - United Kingdom")
                {
                    inputlocale = "0452:00000452";
                }

                else if (input == "Wolof - Senegal")
                {
                    inputlocale = "0488:00000488";
                }

                else if (input == "Yi - PRC")
                {
                    inputlocale = "0478:{E429B25A-E5D3-4D1F-9BE3-0C608477E3A1}{409C8376-007B-4357-AE8E-26316EE3FB0D}";
                }

                else if (input == "Yoruba - Nigeria")
                {
                    inputlocale = "046a:0000046a";
                }

                else
                {
                    MessageBox.Show("Error setting InputLocale Variable. Please contact an Administrator");
                    MessageBox.Show("Using " + input + " as Input Method");
                }


                var userlocale = "en-US"; // English United Kingdom

                if (currency_time == "Afrikaans - South Africa")
                {
                    userlocale = "af-ZA";
                }

                else if (currency_time == "Albanian - Albania")
                {
                    userlocale = "sq-AL";
                }

                else if (currency_time == "Alsatian - France")
                {
                    userlocale = "gsw-FR";
                }

                else if (currency_time == "Amharic - Ethiopia")
                {
                    userlocale = "am-ET";
                }

                else if (currency_time == "Arabic - Algeria")
                {
                    userlocale = "ar-DZ";
                }

                else if (currency_time == "Arabic - Bahrain")
                {
                    userlocale = "ar-BH";
                }

                else if (currency_time == "Arabic - Egypt")
                {
                    userlocale = "ar-EG";
                }

                else if (currency_time == "Arabic - Iraq")
                {
                    userlocale = "ar-IQ";
                }

                else if (currency_time == "Arabic - Jordan")
                {
                    userlocale = "ar-JO";
                }

                else if (currency_time == "Arabic - Kuwait")
                {
                    userlocale = "ar-KW";
                }

                else if (currency_time == "Arabic - Lebanon")
                {
                    userlocale = "ar-LB";
                }

                else if (currency_time == "Arabic - Libya")
                {
                    userlocale = "ar-LY";
                }

                else if (currency_time == "Arabic - Morocco")
                {
                    userlocale = "ar-MA";
                }

                else if (currency_time == "Arabic - Oman")
                {
                    userlocale = "ar-OM";
                }

                else if (currency_time == "Arabic - Qatar")
                {
                    userlocale = "ar-QA";
                }

                else if (currency_time == "Arabic - Saudi Arabia")
                {
                    userlocale = "ar-SA";
                }

                else if (currency_time == "Arabic - Syria")
                {
                    userlocale = "ar-SY";
                }

                else if (currency_time == "Arabic - Tunisia")
                {
                    userlocale = "ar-TN";
                }

                else if (currency_time == "Arabic - U.A.E.")
                {
                    userlocale = "ar-YE";
                }

                else if (currency_time == "Arabic - Yemen")
                {
                    userlocale = "ar-YE";
                }

                else if (currency_time == "Armenian - Armenia")
                {
                    userlocale = "hy-AM";
                }

                else if (currency_time == "Assamese - India")
                {
                    userlocale = "as-IN";
                }

                else if (currency_time == "Azerbaijani - Azerbaijan (Cyrillic)")
                {
                    userlocale = "az-Cyrl-AZ";
                }

                else if (currency_time == "Azerbaijani - Azerbaijan (Latin)")
                {
                    userlocale = "az-Latn-AZ";
                }

                else if (currency_time == "Bangla - Bangladesh")
                {
                    userlocale = "bn-BD";
                }

                else if (currency_time == "Bangla - India (Bengali Script)")
                {
                    userlocale = "bn-IN";
                }

                else if (currency_time == "Bashkir - Russia")
                {
                    userlocale = "ba-RU";
                }

                else if (currency_time == "Basque - Basque")
                {
                    userlocale = "eu-ES";
                }

                else if (currency_time == "Belarusian - Belarus")
                {
                    userlocale = "be-BY";
                }

                else if (currency_time == "Bosnian - Bosnia and Herzegovina (Cyrillic)")
                {
                    userlocale = "bs-Cyrl-BA";
                }

                else if (currency_time == "Bosnian - Bosnia and Herzegovina (Latin)")
                {
                    userlocale = "bs-Latn-BA";
                }

                else if (currency_time == "Breton - France")
                {
                    userlocale = "br-FR";
                }

                else if (currency_time == "Bulgarian - Bulgaria")
                {
                    userlocale = "bg-BG";
                }

                else if (currency_time == "Burmese - Myanmar")
                {
                    userlocale = "my-MM";
                }

                else if (currency_time == "Catalan - Catalan")
                {
                    userlocale = "ca-ES";
                }

                else if (currency_time == "Central Atlas Tamazight (Latin) - Algeria")
                {
                    userlocale = "fr-FR";
                }

                else if (currency_time == "Central Atlas Tamazight (Latin) - Algeria")
                {
                    userlocale = "tzm-Latn-DZ";
                }

                else if (currency_time == "Central Atlas Tamazight (Tifinagh) - Morocco")
                {
                    userlocale = "tzm-Tfng-MA";
                }

                else if (currency_time == "Central Kurdish (Iraq)")
                {
                    userlocale = "ku-Arab-IQ";
                }

                else if (currency_time == "Cherokee (Cherokee, United States)")
                {
                    userlocale = "chr-Cher-US";
                }

                else if (currency_time == "Chinese - Hong Kong")
                {
                    userlocale = "zh-TW";
                }

                else if (currency_time == "Chinese - Macao")
                {
                    userlocale = "zh-TW";
                }

                else if (currency_time == "Chinese - PRC")
                {
                    userlocale = "zh-CN";
                }

                else if (currency_time == "Chinese - Singapore")
                {
                    userlocale = "zh-CN";
                }

                else if (currency_time == "Corsican - France")
                {
                    userlocale = "co-FR";
                }

                else if (currency_time == "Croatian - Bosnia and Herzegovina")
                {
                    userlocale = "hr-BA";
                }

                else if (currency_time == "Croatian - Croatia")
                {
                    userlocale = "hr-HR";
                }

                else if (currency_time == "Czech - Czech Republic")
                {
                    userlocale = "cs-CZ";
                }

                else if (currency_time == "Danish - Denmark")
                {
                    userlocale = "da-DK";
                }

                else if (currency_time == "Dari - Afghanistan")
                {
                    userlocale = "prs-AF";
                }

                else if (currency_time == "Divehi - Maldives")
                {
                    userlocale = "dv-MV";
                }

                else if (currency_time == "Dutch - Belgium")
                {
                    userlocale = "nl-BE";
                }

                else if (currency_time == "Dutch - Netherlands")
                {
                    userlocale = "nl-NL";
                }

                else if (currency_time == "English - Australia")
                {
                    userlocale = "en-AU";
                }

                else if (currency_time == "English - Belize")
                {
                    userlocale = "en-BZ";
                }

                else if (currency_time == "English - Canada")
                {
                    userlocale = "en-CA";
                }

                else if (currency_time == "English - Caribbean")
                {
                    userlocale = "en-029";
                }

                else if (currency_time == "English - India")
                {
                    userlocale = "en-IN";
                }

                else if (currency_time == "English - Ireland")
                {
                    userlocale = "en-IE";
                }

                else if (currency_time == "English - Jamaica")
                {
                    userlocale = "en-JM";
                }

                else if (currency_time == "English - Malaysia")
                {
                    userlocale = "en-MY";
                }

                else if (currency_time == "English - New Zealand")
                {
                    userlocale = "en-NZ";
                }

                else if (currency_time == "English - Philippines")
                {
                    userlocale = "en-PH";
                }

                else if (currency_time == "English - Singapore")
                {
                    userlocale = "en-SG";
                }

                else if (currency_time == "English - South Africa")
                {
                    userlocale = "en-ZA";
                }

                else if (currency_time == "English - Trinidad")
                {
                    userlocale = "en-TT";
                }

                else if (currency_time == "English - United Kingdom")
                {
                    userlocale = "en-GB";
                }

                else if (currency_time == "English - United States")
                {
                    userlocale = "en-US";
                }

                else if (currency_time == "English - Zimbabwe")
                {
                    userlocale = "en-ZW";
                }

                else if (currency_time == "Estonian - Estonia")
                {
                    userlocale = "et-EE";
                }

                else if (currency_time == "Faroese - Faroe Islands")
                {
                    userlocale = "fo-FO";
                }

                else if (currency_time == "Filipino - Philippines")
                {
                    userlocale = "fil-PH";
                }

                else if (currency_time == "Finnish - Finland")
                {
                    userlocale = "fi-FI";
                }

                else if (currency_time == "French - Belgium")
                {
                    userlocale = "fr-BE";
                }

                else if (currency_time == "French - Canada")
                {
                    userlocale = "fr-CA";
                }

                else if (currency_time == "French - France")
                {
                    userlocale = "fr-FR";
                }

                else if (currency_time == "French - Luxembourg")
                {
                    userlocale = "fr-LU";
                }

                else if (currency_time == "French - Monaco")
                {
                    userlocale = "fr-MC";
                }

                else if (currency_time == "French - Switzerland")
                {
                    userlocale = "fr-CH";
                }

                else if (currency_time == "Frisian - Netherlands")
                {
                    userlocale = "fy-NL";
                }

                else if (currency_time == "Fulah (Latin, Senegal)")
                {
                    userlocale = "ff-Latn-SN";
                }

                else if (currency_time == "Galician - Galician")
                {
                    userlocale = "gl-ES";
                }

                else if (currency_time == "Georgian - Georgia")
                {
                    userlocale = "ka-GE";
                }

                else if (currency_time == "German - Austria")
                {
                    userlocale = "de-AT";
                }

                else if (currency_time == "German - Germany")
                {
                    userlocale = "de-DE";
                }

                else if (currency_time == "German - Liechtenstein")
                {
                    userlocale = "de-LI";
                }

                else if (currency_time == "German - Luxembourg")
                {
                    userlocale = "de-LU";
                }

                else if (currency_time == "German - Switzerland")
                {
                    userlocale = "de-CH";
                }

                else if (currency_time == "Greek - Greece")
                {
                    userlocale = "el-GR";
                }

                else if (currency_time == "Greenlandic - Greenland")
                {
                    userlocale = "kl-GL";
                }

                else if (currency_time == "Guarani - Paraguay")
                {
                    userlocale = "gn-PY";
                }

                else if (currency_time == "Gujarati - India (Gujarati Script)")
                {
                    userlocale = "gu-IN";
                }

                else if (currency_time == "Hausa (Latin) - Nigeria")
                {
                    userlocale = "ha-Latn-NG";
                }

                else if (currency_time == "Hawaiian - United States")
                {
                    userlocale = "haw-US";
                }

                else if (currency_time == "Hebrew - Israel")
                {
                    userlocale = "he-IL";
                }

                else if (currency_time == "Hindi - India")
                {
                    userlocale = "hi-IN";
                }

                else if (currency_time == "Hungarian - Hungary")
                {
                    userlocale = "hu-HU";
                }

                else if (currency_time == "Icelandic - Iceland")
                {
                    userlocale = "is-IS";
                }

                else if (currency_time == "Igbo - Nigeria")
                {
                    userlocale = "ig-NG";
                }

                else if (currency_time == "Inari Sami - Finland")
                {
                    userlocale = "smn-FI";
                }

                else if (currency_time == "Indonesian - Indonesia")
                {
                    userlocale = "id-ID";
                }

                else if (currency_time == "Inuktitut (Latin) - Canada")
                {
                    userlocale = "iu-Latn-CA";
                }

                else if (currency_time == "Inuktitut (Syllabics) - Canada")
                {
                    userlocale = "iu-Cans-CA";
                }

                else if (currency_time == "Irish - Ireland")
                {
                    userlocale = "ga-IE";
                }

                else if (currency_time == "isiXhosa / Xhosa - South Africa")
                {
                    userlocale = "xh-ZA";
                }

                else if (currency_time == "isiZulu / Zulu - South Africa")
                {
                    userlocale = "zu-ZA";
                }

                else if (currency_time == "Italian - Italy")
                {
                    userlocale = "it-IT";
                }

                else if (currency_time == "Italian - Switzerland")
                {
                    userlocale = "it-CH";
                }

                else if (currency_time == "Japanese - Japan")
                {
                    userlocale = "ja-JP";
                }

                else if (currency_time == "Javanese (Latin) - Indonesia")
                {
                    userlocale = "jv-Latn-ID";
                }

                else if (currency_time == "Kannada - India (Kannada Script)")
                {
                    userlocale = "kn-IN";
                }

                else if (currency_time == "Kazakh - Kazakhstan")
                {
                    userlocale = "kk-KZ";
                }

                else if (currency_time == "Khmer - Cambodia")
                {
                    userlocale = "km-KH";
                }

                else if (currency_time == "K'iche - Guatemala")
                {
                    userlocale = "qut-GT";
                }

                else if (currency_time == "Kinyarwanda - Rwanda")
                {
                    userlocale = "rw-RW";
                }

                else if (currency_time == "Konkani - India")
                {
                    userlocale = "kok-IN";
                }

                else if (currency_time == "Korean(Extended Wansung) - Korea")
                {
                    userlocale = "ko-KR";
                }

                else if (currency_time == "Kyrgyz - Kyrgyzstan")
                {
                    userlocale = "ky-KG";
                }

                else if (currency_time == "Lao - Lao PDR")
                {
                    userlocale = "lo-LA";
                }

                else if (currency_time == "Latvian - Legacy")
                {
                    userlocale = "lv-LV";
                }

                else if (currency_time == "Latvian - Standard")
                {
                    userlocale = "lv-LV";
                }

                else if (currency_time == "Lithuanian - Lithuania")
                {
                    userlocale = "lt-LT";
                }

                else if (currency_time == "Lower Sorbian - Germany")
                {
                    userlocale = "dsb-DE";
                }

                else if (currency_time == "Lule Sami - Norway")
                {
                    userlocale = "smj-NO";
                }

                else if (currency_time == "Lule Sami - Sweden")
                {
                    userlocale = "smj-SE";
                }

                else if (currency_time == "Luxembourgish - Luxembourg")
                {
                    userlocale = "lb-LU";
                }

                else if (currency_time == "Macedonian - F.Y.R.O.M")
                {
                    userlocale = "mk-MK";
                }

                else if (currency_time == "Malay - Brunei")
                {
                    userlocale = "ms-BN";
                }

                else if (currency_time == "Malay - Malaysia")
                {
                    userlocale = "ms-MY";
                }

                else if (currency_time == "Malayalam - India (Malayalam Script)")
                {
                    userlocale = "ml-IN";
                }

                else if (currency_time == "Maltese - Malta")
                {
                    userlocale = "mt-MT";
                }

                else if (currency_time == "Maori - New Zealand")
                {
                    userlocale = "mi-NZ";
                }

                else if (currency_time == "Mapudungun - Chile")
                {
                    userlocale = "arn-CL";
                }

                else if (currency_time == "Marathi - India")
                {
                    userlocale = "mr-IN";
                }

                else if (currency_time == "Mohawk - Mohawk")
                {
                    userlocale = "moh-CA";
                }

                else if (currency_time == "Mongolian (Cyrillic) - Mongolia")
                {
                    userlocale = "mn-MN";
                }

                else if (currency_time == "Mongolian (Mongolian) - Mongolia")
                {
                    userlocale = "mn-Mong-MN";
                }

                else if (currency_time == "Mongolian (Mongolian - PRC - Legacy)")
                {
                    userlocale = "mn-Mong-CN";
                }

                else if (currency_time == "Mongolian (Mongolian - PRC - Standard)")
                {
                    userlocale = "mn-Mong-CN";
                }

                else if (currency_time == "N'ko - Guinea")
                {
                    userlocale = "nqo-GN";
                }

                else if (currency_time == "Nepali - Nepal")
                {
                    userlocale = "ne-NP";
                }

                else if (currency_time == "Northern Sami - Finland")
                {
                    userlocale = "se-FI";
                }

                else if (currency_time == "Northern Sami - Norway")
                {
                    userlocale = "se-NO";
                }

                else if (currency_time == "Northern Sami - Sweden")
                {
                    userlocale = "se-SE";
                }

                else if (currency_time == "Norwegian - Norway (Bokmal)")
                {
                    userlocale = "nb-NO";
                }

                else if (currency_time == "Norwegian - Norway (Nynorsk)")
                {
                    userlocale = "nn-NO";
                }

                else if (currency_time == "Occitan - France")
                {
                    userlocale = "oc-FR";
                }

                else if (currency_time == "Odia - India (Odia Script)")
                {
                    userlocale = "or-IN";
                }

                else if (currency_time == "Pashto - Afghanistan")
                {
                    userlocale = "ps-AF";
                }

                else if (currency_time == "Persian")
                {
                    userlocale = "fa-IR";
                }

                else if (currency_time == "Polish - Poland")
                {
                    userlocale = "pl-PL";
                }

                else if (currency_time == "Portuguese - Brazil")
                {
                    userlocale = "pt-BR";
                }

                else if (currency_time == "Portuguese - Portugal")
                {
                    userlocale = "pt-PT";
                }

                else if (currency_time == "Punjabi - India (Gurmukhi Script)")
                {
                    userlocale = "pa-IN";
                }

                else if (currency_time == "Punjabi (Islamic Republic of Pakistan)")
                {
                    userlocale = "pa-Arab-PK";
                }

                else if (currency_time == "Quechua - Bolivia")
                {
                    userlocale = "quz-BO";
                }

                else if (currency_time == "Quechua - Ecuador")
                {
                    userlocale = "quz-EC";
                }

                else if (currency_time == "Quechua - Peru")
                {
                    userlocale = "quz-PE";
                }

                else if (currency_time == "Romanian - Romania")
                {
                    userlocale = "ro-RO";
                }

                else if (currency_time == "Romansh - Switzerland")
                {
                    userlocale = "rm-CH";
                }

                else if (currency_time == "Russian - Russia")
                {
                    userlocale = "ru-RU";
                }

                else if (currency_time == "Sakha - Russia")
                {
                    userlocale = "sah-RU";
                }

                else if (currency_time == "Sanskrit - India")
                {
                    userlocale = "sa-IN";
                }

                else if (currency_time == "Scottish Gaelic - United Kingdom")
                {
                    userlocale = "gd-GB";
                }

                else if (currency_time == "Serbian - Bosnia and Herzegovina (Cyrillic)")
                {
                    userlocale = "sr-Cyrl-BA";
                }

                else if (currency_time == "Serbian - Bosnia and Herzegovina (Latin)")
                {
                    userlocale = "sr-Latn-BA";
                }

                else if (currency_time == "Serbian - Montenegro (Cyrillic)")
                {
                    userlocale = "sr-Cyrl-ME";
                }

                else if (currency_time == "Serbian - Montenegro (Latin)")
                {
                    userlocale = "sr-Latn-ME";
                }

                else if (currency_time == "Serbian - Serbia (Cyrillic)")
                {
                    userlocale = "sr-Cyrl-RS";
                }

                else if (currency_time == "Serbian - Serbia (Latin)")
                {
                    userlocale = "sr-Latn-RS";
                }

                else if (currency_time == "Serbian - Serbia and Montenegro (Former) (Cyrillic)")
                {
                    userlocale = "sr-Cyrl-CS";
                }

                else if (currency_time == "Serbian - Serbia and Montenegro (Former) (Latin)")
                {
                    userlocale = "sr-Latn-CS";
                }

                else if (currency_time == "Sesotho sa Leboa / Northern Sotho - South Africa")
                {
                    userlocale = "nso-ZA";
                }

                else if (currency_time == "Setswana / Tswana - Botswana")
                {
                    userlocale = "tn-BW";
                }

                else if (currency_time == "Setswana / Tswana - South Africa")
                {
                    userlocale = "tn-ZA";
                }

                else if (currency_time == "Shona - Zimbabwe")
                {
                    userlocale = "sn-Latn-ZW";
                }

                else if (currency_time == "Sindhi (Islamic Republic of Pakistan)")
                {
                    userlocale = "sd-Arab-PK";
                }

                else if (currency_time == "Sinhala - Sri Lanka")
                {
                    userlocale = "si-LK";
                }

                else if (currency_time == "Skolt Sami - Finland")
                {
                    userlocale = "sms-FI";
                }

                else if (currency_time == "Slovak - Slovakia")
                {
                    userlocale = "sk-SK";
                }

                else if (currency_time == "Slovenian - Slovenia")
                {
                    userlocale = "sl-SI";
                }

                else if (currency_time == "Southern Sami - Norway")
                {
                    userlocale = "sma-NO";
                }

                else if (currency_time == "Southern Sami - Sweden")
                {
                    userlocale = "sma-SE";
                }

                else if (currency_time == "Spanish - Argentina")
                {
                    userlocale = "es-AR";
                }

                else if (currency_time == "Spanish - Bolivarian Republic of Venezuela")
                {
                    userlocale = "es-VE";
                }

                else if (currency_time == "Spanish - Bolivia")
                {
                    userlocale = "es-BO";
                }

                else if (currency_time == "Spanish - Chile")
                {
                    userlocale = "es-CL";
                }

                else if (currency_time == "Spanish - Colombia")
                {
                    userlocale = "es-CO";
                }

                else if (currency_time == "Spanish - Costa Rica")
                {
                    userlocale = "es-CR";
                }

                else if (currency_time == "Spanish - Dominican Republic")
                {
                    userlocale = "es-DO";
                }

                else if (currency_time == "Spanish - Ecuador")
                {
                    userlocale = "es-EC";
                }

                else if (currency_time == "Spanish - El Salvador")
                {
                    userlocale = "es-SV";
                }

                else if (currency_time == "Spanish - Guatemala")
                {
                    userlocale = "es-GT";
                }

                else if (currency_time == "Spanish - Honduras")
                {
                    userlocale = "es-HN";
                }

                else if (currency_time == "Spanish - Mexico")
                {
                    userlocale = "es-MX";
                }

                else if (currency_time == "Spanish - Nicaragua")
                {
                    userlocale = "es-NI";
                }

                else if (currency_time == "Spanish - Panama")
                {
                    userlocale = "es-PA";
                }

                else if (currency_time == "Spanish - Paraguay")
                {
                    userlocale = "es-PY";
                }

                else if (currency_time == "Spanish - Peru")
                {
                    userlocale = "es-PE";
                }

                else if (currency_time == "Spanish - Puerto Rico")
                {
                    userlocale = "es-PR";
                }

                else if (currency_time == "Spanish - Spain (International Sort)")
                {
                    userlocale = "es-ES";
                }

                else if (currency_time == "Spanish - Spain (Traditional Sort)")
                {
                    userlocale = "es-ES_tradnl";
                }

                else if (currency_time == "Spanish - United States")
                {
                    userlocale = "es-US";
                }

                else if (currency_time == "Spanish - Uruguay")
                {
                    userlocale = "es-UY";
                }

                else if (currency_time == "Standard Moroccan Tamazight - Morocco")
                {
                    userlocale = "zgh-Tfng-MA";
                }

                else if (currency_time == "Swahili - Kenya")
                {
                    userlocale = "sw-KE";
                }

                else if (currency_time == "Swedish - Finland")
                {
                    userlocale = "sv-FI";
                }

                else if (currency_time == "Swedish - Sweden")
                {
                    userlocale = "sv-SE";
                }

                else if (currency_time == "Syriac - Syria")
                {
                    userlocale = "syr-SY";
                }

                else if (currency_time == "Tajik - Tajikistan")
                {
                    userlocale = "tg-Cyrl-TJ";
                }

                else if (currency_time == "Tamil - India")
                {
                    userlocale = "ta-IN";
                }

                else if (currency_time == "Tamil - Sri Lanka")
                {
                    userlocale = "ta-LK";
                }

                else if (currency_time == "Tatar - Russia (Legacy)")
                {
                    userlocale = "tt-RU";
                }

                else if (currency_time == "Tatar - Russia (Standard)")
                {
                    userlocale = "tt-RU";
                }

                else if (currency_time == "Telugu - India (Telugu Script)")
                {
                    userlocale = "te-IN";
                }

                else if (currency_time == "Thai - Thailand")
                {
                    userlocale = "th-TH";
                }

                else if (currency_time == "Tibetan - PRC")
                {
                    userlocale = "bo-CN";
                }

                else if (currency_time == "Tigrinya (Eritrea)")
                {
                    userlocale = "ti-ET";
                }

                else if (currency_time == "Tigrinya (Ethiopia)")
                {
                    userlocale = "ti-ET";
                }

                else if (currency_time == "Turkish - Turkey")
                {
                    userlocale = "tr-TR";
                }

                else if (currency_time == "Turkmen - Turkmenistan")
                {
                    userlocale = "tk-TM";
                }

                else if (currency_time == "Ukrainian - Ukraine")
                {
                    userlocale = "uk-UA";
                }

                else if (currency_time == "Upper Sorbian - Germany")
                {
                    userlocale = "hsb-DE";
                }

                else if (currency_time == "Urdu - India")
                {
                    userlocale = "ur-IN";
                }

                else if (currency_time == "Urdu (Islamic Republic of Pakistan)")
                {
                    userlocale = "ur-PK";
                }

                else if (currency_time == "Uyghur - PRC")
                {
                    userlocale = "ug-CN";
                }

                else if (currency_time == "Uzbek - Uzbekistan (Cyrillic)")
                {
                    userlocale = "uz-Cyrl-UZ";
                }

                else if (currency_time == "Uzbek - Uzbekistan (Latin)")
                {
                    userlocale = "uz-Latn-UZ";
                }

                else if (currency_time == "Valencian - Valencia")
                {
                    userlocale = "ca-ES-valencia";
                }

                else if (currency_time == "Vietnamese - Vietnam")
                {
                    userlocale = "vi-VN";
                }

                else if (currency_time == "Welsh - United Kingdom")
                {
                    userlocale = "cy-GB";
                }

                else if (currency_time == "Wolof - Senegal")
                {
                    userlocale = "wo-SN";
                }

                else if (currency_time == "Yi - PRC")
                {
                    userlocale = "ii-CN";
                }

                else if (currency_time == "Yoruba - Nigeria")
                {
                    userlocale = "yo-NG";
                }

                else
                {
                    MessageBox.Show("Error setting UserLocale Variable. Please contact an Administrator");
                    MessageBox.Show("Using " + userlocale + " as Currency and Date Format");
                }

                var zonetime = "";

                if (timezone == "(UTC-12:00) International Date Line West")
                {
                    zonetime = "Dateline Standard Time";
                }

                else if (timezone == "(UTC-11:00) Midway Island, Samoa")
                {
                    zonetime = "UTC-11";
                }

                else if (timezone == "(UTC-10:00) Hawaii")
                {
                    zonetime = "Hawaiian Standard Time";
                }

                else if (timezone == "(UTC-09:00) Alaska")
                {
                    zonetime = "Alaskan Standard Time";
                }

                else if (timezone == "(UTC-08:00) Pacific Time (US & Canada)")
                {
                    zonetime = "Pacific Standard Time";
                }

                else if (timezone == "(UTC-08:00) Tijuana, Baja California")
                {
                    zonetime = "Pacific Standard Time (Mexico)";
                }

                else if (timezone == "(UTC-07:00) Arizona")
                {
                    zonetime = "US Mountain Standard Time";
                }

                else if (timezone == "(UTC-07:00) Chihuahua, La Paz, Mazatlan")
                {
                    zonetime = "Mountain Standard Time (Mexico)";
                }

                else if (timezone == "(UTC-07:00) Mountain Time (US & Canada)")
                {
                    zonetime = "Mountain Standard Time";
                }

                else if (timezone == "(UTC-06:00) Central America")
                {
                    zonetime = "Central America Standard Time";
                }

                else if (timezone == "(UTC-06:00) Central Time (US & Canada)")
                {
                    zonetime = "Central Standard Time";
                }

                else if (timezone == "(UTC-06:00) Guadalajara, Mexico City, Monterrey")
                {
                    zonetime = "Central Standard Time (Mexico)";
                }

                else if (timezone == "(UTC-06:00) Saskatchewan")
                {
                    zonetime = "Canada Central Standard Time";
                }

                else if (timezone == "(UTC-05:00) Bogota, Lima, Quito")
                {
                    zonetime = "SA Pacific Standard Time";
                }

                else if (timezone == "(UTC-05:00) Eastern Time (US & Canada)")
                {
                    zonetime = "Eastern Standard Time";
                }

                else if (timezone == "(UTC-05:00) Indiana (East)")
                {
                    zonetime = "US Eastern Standard Time";
                }

                else if (timezone == "(UTC-04:30) Caracas")
                {
                    zonetime = "Venezuela Standard Time";
                }

                else if (timezone == "(UTC-04:00) Asuncion")
                {
                    zonetime = "Paraguay Standard Time";
                }

                else if (timezone == "(UTC-04:00) Atlantic Time (Canada)")
                {
                    zonetime = "Atlantic Standard Time";
                }

                else if (timezone == "(UTC-04:00) Georgetown, La Paz, San Juan")
                {
                    zonetime = "SA Western Standard Time";
                }

                else if (timezone == "(UTC-04:00) Santiago")
                {
                    zonetime = "Pacific SA Standard Time";
                }

                else if (timezone == "(UTC-03:30) Newfoundland")
                {
                    zonetime = "Newfoundland Standard Time";
                }

                else if (timezone == "(UTC-03:00) Brasilia")
                {
                    zonetime = "E. South America Standard Time";
                }

                else if (timezone == "(UTC-03:00) Buenos Aires")
                {
                    zonetime = "Argentina Standard Time";
                }

                else if (timezone == "(UTC-03:00) Cayenne")
                {
                    zonetime = "SA Eastern Standard Time";
                }

                else if (timezone == "(UTC-03:00) Greenland")
                {
                    zonetime = "Greenland Standard Time";
                }

                else if (timezone == "(UTC-03:00) Montevideo")
                {
                    zonetime = "Montevideo Standard Time";
                }

                else if (timezone == "(UTC-02:00) Mid-Atlantic")
                {
                    zonetime = "Mid-Atlantic Standard Time";
                }

                else if (timezone == "(UTC-01:00) Azores")
                {
                    zonetime = "Azores Standard Time";
                }

                else if (timezone == "(UTC-01:00) Cape Verde Is.")
                {
                    zonetime = "Cape Verde Standard Time";
                }

                else if (timezone == "(UTC) Casablanca")
                {
                    zonetime = "Morocco Standard Time";
                }

                else if (timezone == "(UTC) Coordinated Universal Time")
                {
                    zonetime = "UTC";
                }

                else if (timezone == "(UTC) Dublin, Edinburgh, Lisbon, London")
                {
                    zonetime = "GMT Standard Time";
                }

                else if (timezone == "(UTC) Monrovia, Reykjavik")
                {
                    zonetime = "Greenwich Standard Time";
                }

                else if (timezone == "(UTC+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna")
                {
                    zonetime = "W. Europe Standard Time";
                }

                else if (timezone == "(UTC+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague")
                {
                    zonetime = "Central Europe Standard Time";
                }

                else if (timezone == "(UTC+01:00) Brussels, Copenhagen, Madrid, Paris")
                {
                    zonetime = "Romance Standard Time";
                }

                else if (timezone == "(UTC+01:00) Sarajevo, Skopje, Warsaw, Zagreb")
                {
                    zonetime = "Central European Standard Time";
                }

                else if (timezone == "(UTC+01:00) West Central Africa")
                {
                    zonetime = "W. Central Africa Standard Time";
                }

                else if (timezone == "(UTC+02:00) Amman")
                {
                    zonetime = "Jordan Standard Time";
                }

                else if (timezone == "(UTC+02:00) Athens, Bucharest, Istanbul")
                {
                    zonetime = "GTB Standard Time";
                }

                else if (timezone == "(UTC+02:00) Beirut")
                {
                    zonetime = "Middle East Standard Time";
                }

                else if (timezone == "(UTC+02:00) Cairo")
                {
                    zonetime = "Egypt Standard Time";
                }

                else if (timezone == "(UTC+02:00) Harare, Pretoria")
                {
                    zonetime = "South Africa Standard Time";
                }

                else if (timezone == "(UTC+02:00) Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius")
                {
                    zonetime = "FLE Standard Time";
                }

                else if (timezone == "(UTC+02:00) Jerusalem")
                {
                    zonetime = "Israel Standard Time";
                }

                else if (timezone == "(UTC+02:00) Minsk")
                {
                    zonetime = "Kaliningrad Standard Time";
                }

                else if (timezone == "(UTC+02:00) Windhoek")
                {
                    zonetime = "Namibia Standard Time";
                }

                else if (timezone == "(UTC+03:00) Baghdad")
                {
                    zonetime = "Arabic Standard Time";
                }

                else if (timezone == "(UTC+03:00) Kuwait, Riyadh")
                {
                    zonetime = "Arab Standard Time";
                }

                else if (timezone == "(UTC+03:00) Moscow, St. Petersburg, Volgograd")
                {
                    zonetime = "Russian Standard Time";
                }

                else if (timezone == "(UTC+03:00) Nairobi")
                {
                    zonetime = "E. Africa Standard Time";
                }

                else if (timezone == "(UTC+03:00) Tbilisi")
                {
                    zonetime = "Georgian Standard Time";
                }

                else if (timezone == "(UTC+03:30) Tehran")
                {
                    zonetime = "Iran Standard Time";
                }

                else if (timezone == "(UTC+04:00) Abu Dhabi, Muscat")
                {
                    zonetime = "Arabian Standard Time";
                }

                else if (timezone == "(UTC+04:00) Baku")
                {
                    zonetime = "Azerbaijan Standard Time";
                }

                else if (timezone == "(UTC+04:00) Port Louis")
                {
                    zonetime = "Mauritius Standard Time";
                }

                else if (timezone == "(UTC+04:00) Yerevan")
                {
                    zonetime = "Caucasus Standard Time";
                }

                else if (timezone == "(UTC+04:30) Kabul")
                {
                    zonetime = "Afghanistan Standard Time";
                }

                else if (timezone == "(UTC+05:00) Ekaterinburg")
                {
                    zonetime = "Ekaterinburg Standard Time";
                }

                else if (timezone == "(UTC+05:00) Islamabad, Karachi")
                {
                    zonetime = "Pakistan Standard Time";
                }

                else if (timezone == "(UTC+05:00) Tashkent")
                {
                    zonetime = "West Asia Standard Time";
                }

                else if (timezone == "(UTC+05:30) Chennai, Kolkata, Mumbai, New Delhi")
                {
                    zonetime = "India Standard Time";
                }

                else if (timezone == "(UTC+05:45) Kathmandu")
                {
                    zonetime = "Nepal Standard Time";
                }

                else if (timezone == "(UTC+06:00) Almaty, Novosibirsk")
                {
                    zonetime = "N. Central Asia Standard Time";
                }

                else if (timezone == "(UTC+06:00) Astana, Dhaka")
                {
                    zonetime = "Central Asia Standard Time";
                }

                else if (timezone == "(UTC+06:30) Yangon (Rangoon)")
                {
                    zonetime = "Myanmar Standard Time";
                }

                else if (timezone == "(UTC+07:00) Bangkok, Hanoi, Jakarta")
                {
                    zonetime = "SE Asia Standard Time";
                }

                else if (timezone == "(UTC+07:00) Krasnoyarsk")
                {
                    zonetime = "North Asia Standard Time";
                }

                else if (timezone == "(UTC+08:00) Beijing, Chongqing, Hong Kong, Urumqi")
                {
                    zonetime = "China Standard Time";
                }

                else if (timezone == "(UTC+08:00) Irkutsk, Ulaan Bataar")
                {
                    zonetime = "North Asia East Standard Time";
                }

                else if (timezone == "(UTC+08:00) Kuala Lumpur, Singapore")
                {
                    zonetime = "Singapore Standard Time";
                }

                else if (timezone == "(UTC+08:00) Perth")
                {
                    zonetime = "W. Australia Standard Time";
                }

                else if (timezone == "(UTC+08:00) Taipei")
                {
                    zonetime = "Taipei Standard Time";
                }

                else if (timezone == "(UTC+09:00) Osaka, Sapporo, Tokyo")
                {
                    zonetime = "Tokyo Standard Time";
                }

                else if (timezone == "(UTC+09:00) Seoul")
                {
                    zonetime = "Korea Standard Time";
                }

                else if (timezone == "(UTC+09:00) Yakutsk")
                {
                    zonetime = "Yakutsk Standard Time";
                }

                else if (timezone == "(UTC+09:30) Adelaide")
                {
                    zonetime = "Cen. Australia Standard Time";
                }

                else if (timezone == "(UTC+09:30) Darwin")
                {
                    zonetime = "AUS Central Standard Time";
                }

                else if (timezone == "(UTC+10:00) Brisbane")
                {
                    zonetime = "E. Australia Standard Time";
                }

                else if (timezone == "(UTC+10:00) Canberra, Melbourne, Sydney")
                {
                    zonetime = "AUS Eastern Standard Time";
                }

                else if (timezone == "(UTC+10:00) Guam, Port Moresby")
                {
                    zonetime = "West Pacific Standard Time";
                }

                else if (timezone == "(UTC+10:00) Hobart")
                {
                    zonetime = "Tasmania Standard Time";
                }

                else if (timezone == "(UTC+10:00) Vladivostok")
                {
                    zonetime = "Vladivostok Standard Time";
                }

                else if (timezone == "(UTC+11:00) Magadan, Solomon Is., New Caledonia")
                {
                    zonetime = "Central Pacific Standard Time";
                }

                else if (timezone == "(UTC+12:00) Auckland, Wellington")
                {
                    zonetime = "New Zealand Standard Time";
                }

                else if (timezone == "(UTC+12:00) Fiji, Marshall Is.")
                {
                    zonetime = "Fiji Standard Time";
                }

                else if (timezone == "(UTC+12:00) Petropavlovsk-Kamchatsky")
                {
                    zonetime = "UTC+12";
                }

                else if (timezone == "(UTC+13:00) Nuku'alofa")
                {
                    zonetime = "Tonga Standard Time";
                }

                else
                {
                    MessageBox.Show("Error setting timezone Variable. Please contact an Administrator");
                }

                debug.Text = "";
                debug.AppendText(System.Environment.NewLine + "<!--*************************************************");
                debug.AppendText(System.Environment.NewLine + "Windows 10 Answer File Generator");
                debug.AppendText(System.Environment.NewLine + "Created using WAF Generator made by Sebi 2021");
                debug.AppendText(System.Environment.NewLine + "");
                debug.AppendText(System.Environment.NewLine + "");
                debug.AppendText(System.Environment.NewLine + "Notes: ");
                debug.AppendText(System.Environment.NewLine + "File created by: " + CreatedBy);
                debug.AppendText(System.Environment.NewLine + "Domain: " + Domain);
                debug.AppendText(System.Environment.NewLine + "Created at: " + Time);
                debug.AppendText(System.Environment.NewLine + "*************************************************-->");
                debug.AppendText(System.Environment.NewLine + "");
                debug.AppendText(System.Environment.NewLine + "<?xml version='1.0' encoding='utf - 8'?>");
                debug.AppendText(System.Environment.NewLine + "<unattend xmlns='urn:schemas-microsoft-com:unattend'>");
                debug.AppendText(System.Environment.NewLine + "<settings pass='windowsPE'>");
                debug.AppendText(System.Environment.NewLine + "<component name='Microsoft-Windows-International-Core-WinPE' processorArchitecture='amd64' publicKeyToken='31bf3856ad364e35' language='neutral' versionScope='nonSxS' xmlns:wcm='http://schemas.microsoft.com/WMIConfig/2002/State' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'>");
                debug.AppendText(System.Environment.NewLine + "<SetupUILanguage>");
                debug.AppendText(System.Environment.NewLine + "<UILanguage>" + languageUI + "</UILanguage>");
                debug.AppendText(System.Environment.NewLine + "</SetupUILanguage>");
                debug.AppendText(System.Environment.NewLine + "<InputLocale>" + inputlocale + "</InputLocale>");
                debug.AppendText(System.Environment.NewLine + "<SystemLocale>" + languageUI + "</SystemLocale>");
                debug.AppendText(System.Environment.NewLine + "<UILanguage>" + languageUI + "</UILanguage>");
                debug.AppendText(System.Environment.NewLine + "<UILanguageFallback>" + languageUI + "</UILanguageFallback>");
                debug.AppendText(System.Environment.NewLine + "<UserLocale>" + userlocale + "</UserLocale>");
                debug.AppendText(System.Environment.NewLine + "</component>");
                debug.AppendText(System.Environment.NewLine + "<component name='Microsoft-Windows-Setup' processorArchitecture='amd64' publicKeyToken='31bf3856ad364e35' language='neutral' versionScope='nonSxS' xmlns:wcm='http://schemas.microsoft.com/WMIConfig/2002/State' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'>");
                debug.AppendText(System.Environment.NewLine + "<DiskConfiguration>");
                debug.AppendText(System.Environment.NewLine + "<Disk wcm:action='add'>");
                debug.AppendText(System.Environment.NewLine + "<DiskID>0</DiskID>");
                bool wd = false;
                if (wipe_disk == "Yes") { wd = true; }
                else if(wipe_disk == "No") { wd = false; }
                else { MessageBox.Show("Error Setting 'Wipe Disk' Variable, Please contact an Administrator, Set Variable to FALSE"); }
                debug.AppendText(System.Environment.NewLine + "<WillWipeDisk>" + wd + "</WillWipeDisk>");
                debug.AppendText(System.Environment.NewLine + "<CreatePartitions>");
                debug.AppendText(System.Environment.NewLine + "<!-- Windows RE Tools partition -->");
                debug.AppendText(System.Environment.NewLine + "<CreatePartition wcm:action='add'>");
                debug.AppendText(System.Environment.NewLine + "<Order>1</Order>");
                debug.AppendText(System.Environment.NewLine + "<Type>Primary</Type>");
                debug.AppendText(System.Environment.NewLine + "<Size>300</Size>");
                debug.AppendText(System.Environment.NewLine + "</CreatePartition>");
                debug.AppendText(System.Environment.NewLine + "<!-- System partition (ESP) -->");
                debug.AppendText(System.Environment.NewLine + "<CreatePartition wcm:action='add'>");
                debug.AppendText(System.Environment.NewLine + "<Order>2</Order>");
                debug.AppendText(System.Environment.NewLine + "<Type>EFI</Type>");
                debug.AppendText(System.Environment.NewLine + "<Size>100</Size>");
                debug.AppendText(System.Environment.NewLine + "</CreatePartition>");
                debug.AppendText(System.Environment.NewLine + "<!-- Microsoft reserved partition (MSR) -->");
                debug.AppendText(System.Environment.NewLine + "<CreatePartition wcm:action='add'>");
                debug.AppendText(System.Environment.NewLine + "<Order>3</Order>");
                debug.AppendText(System.Environment.NewLine + "<Type>MSR</Type>");
                debug.AppendText(System.Environment.NewLine + "<Size>128</Size>");
                debug.AppendText(System.Environment.NewLine + "</CreatePartition>");
                debug.AppendText(System.Environment.NewLine + "<!-- Windows partition -->");
                debug.AppendText(System.Environment.NewLine + "<CreatePartition wcm:action='add'>");
                debug.AppendText(System.Environment.NewLine + "<Order>4</Order>");
                debug.AppendText(System.Environment.NewLine + "<Type>Primary</Type>");
                debug.AppendText(System.Environment.NewLine + "<Extend>true</Extend>");
                debug.AppendText(System.Environment.NewLine + "</CreatePartition>");
                debug.AppendText(System.Environment.NewLine + "</CreatePartitions>");
                debug.AppendText(System.Environment.NewLine + "<ModifyPartitions>");
                debug.AppendText(System.Environment.NewLine + "<!-- Windows RE Tools partition -->");
                debug.AppendText(System.Environment.NewLine + "<ModifyPartition wcm:action='add'>");
                debug.AppendText(System.Environment.NewLine + "<Order>1</Order>");
                debug.AppendText(System.Environment.NewLine + "<PartitionID>1</PartitionID>");
                debug.AppendText(System.Environment.NewLine + "<Label>WINRE</Label>");
                debug.AppendText(System.Environment.NewLine + "<Format>NTFS</Format>");
                debug.AppendText(System.Environment.NewLine + "<TypeID>DE94BBA4-06D1-4D40-A16A-BFD50179D6AC</TypeID>");
                debug.AppendText(System.Environment.NewLine + "</ModifyPartition>");
                debug.AppendText(System.Environment.NewLine + "<!-- System partition (ESP) -->");
                debug.AppendText(System.Environment.NewLine + "<ModifyPartition wcm:action='add'>");
                debug.AppendText(System.Environment.NewLine + "<Order>2</Order>");
                debug.AppendText(System.Environment.NewLine + "<PartitionID>2</PartitionID>");
                debug.AppendText(System.Environment.NewLine + "<Label>System</Label>");
                debug.AppendText(System.Environment.NewLine + "<Format>FAT32</Format>");
                debug.AppendText(System.Environment.NewLine + "</ModifyPartition>");
                debug.AppendText(System.Environment.NewLine + "<!-- MSR partition does not need to be modified -->");
                debug.AppendText(System.Environment.NewLine + "<ModifyPartition wcm:action='add'>");
                debug.AppendText(System.Environment.NewLine + "<Order>3</Order>");
                debug.AppendText(System.Environment.NewLine + "<PartitionID>3</PartitionID>");
                debug.AppendText(System.Environment.NewLine + "</ModifyPartition>");
                debug.AppendText(System.Environment.NewLine + "<!-- Windows partition -->");
                debug.AppendText(System.Environment.NewLine + "<ModifyPartition wcm:action='add'>");
                debug.AppendText(System.Environment.NewLine + "<Order>" + partition_order + "</Order>");
                debug.AppendText(System.Environment.NewLine + "<PartitionID>" + partition_order + "</PartitionID>");
                debug.AppendText(System.Environment.NewLine + "<Label>" + mp_label + "</Label>");
                debug.AppendText(System.Environment.NewLine + "<Letter>" + mp_letter + "</Letter>");
                debug.AppendText(System.Environment.NewLine + "<Format>" + mp_format + "</Format>");
                debug.AppendText(System.Environment.NewLine + "</ModifyPartition>");
                debug.AppendText(System.Environment.NewLine + "</ModifyPartitions>");
                debug.AppendText(System.Environment.NewLine + "</Disk>");
                debug.AppendText(System.Environment.NewLine + "</DiskConfiguration>");
                debug.AppendText(System.Environment.NewLine + "<ImageInstall>");
                debug.AppendText(System.Environment.NewLine + "<OSImage>");
                debug.AppendText(System.Environment.NewLine + "<InstallTo>");
                debug.AppendText(System.Environment.NewLine + "<DiskID>" + install_to_disk + "</DiskID>");
                debug.AppendText(System.Environment.NewLine + "<PartitionID>" + partition_order + "</PartitionID>");
                debug.AppendText(System.Environment.NewLine + "</InstallTo>");
                debug.AppendText(System.Environment.NewLine + "<InstallToAvailablePartition>false</InstallToAvailablePartition>");
                debug.AppendText(System.Environment.NewLine + "</OSImage>");
                debug.AppendText(System.Environment.NewLine + "</ImageInstall>");
                debug.AppendText(System.Environment.NewLine + "<UserData>");
                debug.AppendText(System.Environment.NewLine + "<ProductKey>");
                debug.AppendText(System.Environment.NewLine + "<!-- Do not uncomment the Key element if you are using trial ISOs -->");
                debug.AppendText(System.Environment.NewLine + "<!-- You must uncomment the Key element (and optionally insert your own key) if you are using retail or volume license ISOs -->");
                debug.AppendText(System.Environment.NewLine + "<Key></Key>");
                debug.AppendText(System.Environment.NewLine + "<WillShowUI>Never</WillShowUI>");
                debug.AppendText(System.Environment.NewLine + "</ProductKey>");
                debug.AppendText(System.Environment.NewLine + "<AcceptEula>" + eula + "</AcceptEula>");
                debug.AppendText(System.Environment.NewLine + "<FullName>" + username + "</FullName>");
                debug.AppendText(System.Environment.NewLine + "<Organization>" + orgname + "</Organization>");
                debug.AppendText(System.Environment.NewLine + "</UserData>");
                debug.AppendText(System.Environment.NewLine + "</component>");
                debug.AppendText(System.Environment.NewLine + "</settings>");
                debug.AppendText(System.Environment.NewLine + "<settings pass='offlineServicing'>");
                debug.AppendText(System.Environment.NewLine + "<component name='Microsoft-Windows-LUA-Settings' processorArchitecture='amd64' publicKeyToken='31bf3856ad364e35' language='neutral' versionScope='nonSxS' xmlns:wcm='http://schemas.microsoft.com/WMIConfig/2002/State' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'>");
                bool elua = false;
                if (uac == "Enabled") { elua = true; }
                else if (uac == "Disabled") { elua = false; }
                else { MessageBox.Show("Error Setting 'UAC' Variable, Please contact an Administrator, Set Variable to DISABLED"); }
                debug.AppendText(System.Environment.NewLine + "<EnableLUA>" + elua + "</EnableLUA>");
                debug.AppendText(System.Environment.NewLine + "</component>");
                debug.AppendText(System.Environment.NewLine + "</settings>");
                debug.AppendText(System.Environment.NewLine + "<settings pass='generalize'>");
                debug.AppendText(System.Environment.NewLine + "<component name='Microsoft-Windows-Security-SPP' processorArchitecture='amd64' publicKeyToken='31bf3856ad364e35' language='neutral' versionScope='nonSxS' xmlns:wcm='http://schemas.microsoft.com/WMIConfig/2002/State' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'>");
                debug.AppendText(System.Environment.NewLine + "<SkipRearm>1</SkipRearm>");
                debug.AppendText(System.Environment.NewLine + "</component>");
                debug.AppendText(System.Environment.NewLine + "</settings>");
                debug.AppendText(System.Environment.NewLine + "<settings pass='specialize'>");
                debug.AppendText(System.Environment.NewLine + "<component name='Microsoft-Windows-International-Core' processorArchitecture='amd64' publicKeyToken='31bf3856ad364e35' language='neutral' versionScope='nonSxS' xmlns:wcm='http://schemas.microsoft.com/WMIConfig/2002/State' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'>");
                debug.AppendText(System.Environment.NewLine + "<InputLocale>" + inputlocale + "</InputLocale>");
                debug.AppendText(System.Environment.NewLine + "<SystemLocale>" + languageUI + "</SystemLocale>");
                debug.AppendText(System.Environment.NewLine + "<UILanguage>" + languageUI + "</UILanguage>");
                debug.AppendText(System.Environment.NewLine + "<UILanguageFallback>" + languageUI + "</UILanguageFallback>");
                debug.AppendText(System.Environment.NewLine + "<UserLocale>" + languageUI + "</UserLocale>");
                debug.AppendText(System.Environment.NewLine + "</component>");
                debug.AppendText(System.Environment.NewLine + "<component name='Microsoft-Windows-Security-SPP-UX' processorArchitecture='amd64' publicKeyToken='31bf3856ad364e35' language='neutral' versionScope='nonSxS' xmlns:wcm='http://schemas.microsoft.com/WMIConfig/2002/State' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'>");
                bool aa = false;
                if (skip_automatic_activation == "Yes") { aa = true; }
                else if (skip_automatic_activation == "No") { aa = false; }
                else { MessageBox.Show("Error Setting 'Skip_Automatic_Activation' Variable, Please contact an Administrator, Set Variable to FALSE"); }
                debug.AppendText(System.Environment.NewLine + "<SkipAutoActivation>" + aa + "</SkipAutoActivation>");
                debug.AppendText(System.Environment.NewLine + "</component>");
                debug.AppendText(System.Environment.NewLine + "<component name='Microsoft-Windows-SQMApi' processorArchitecture='amd64' publicKeyToken='31bf3856ad364e35' language='neutral' versionScope='nonSxS' xmlns:wcm='http://schemas.microsoft.com/WMIConfig/2002/State' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'>");
                bool ceipe = false;
                if (ceip == "Enabled") { ceipe = true; }
                else if (ceip == "Disabled") { ceipe = false; }
                else { MessageBox.Show("Error Setting 'ceip' Variable, Please contact an Administrator, Set Variable to FALSE"); }
                debug.AppendText(System.Environment.NewLine + "<CEIPEnabled>" + ceipe + "</CEIPEnabled>");
                debug.AppendText(System.Environment.NewLine + "</component>");
                debug.AppendText(System.Environment.NewLine + "<component name='Microsoft-Windows-Shell-Setup' processorArchitecture='amd64' publicKeyToken='31bf3856ad364e35' language='neutral' versionScope='nonSxS' xmlns:wcm='http://schemas.microsoft.com/WMIConfig/2002/State' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'>");
                debug.AppendText(System.Environment.NewLine + "<ComputerName>" + pcname + "</ComputerName>");
                debug.AppendText(System.Environment.NewLine + "<ProductKey>" + prodkey + "</ProductKey>");
                debug.AppendText(System.Environment.NewLine + "</component>");
                debug.AppendText(System.Environment.NewLine + "</settings>");
                debug.AppendText(System.Environment.NewLine + "<settings pass='oobeSystem'>");
                debug.AppendText(System.Environment.NewLine + "<component name='Microsoft-Windows-Shell-Setup' processorArchitecture='amd64' publicKeyToken='31bf3856ad364e35' language='neutral' versionScope='nonSxS' xmlns:wcm='http://schemas.microsoft.com/WMIConfig/2002/State' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'>");
                debug.AppendText(System.Environment.NewLine + "<AutoLogon>");
                debug.AppendText(System.Environment.NewLine + "<Password>");
                debug.AppendText(System.Environment.NewLine + "<Value>" + optpwd + "</Value>");
                debug.AppendText(System.Environment.NewLine + "<PlainText>true</PlainText>");
                debug.AppendText(System.Environment.NewLine + "</Password>");
                bool lo = false;
                if (logon == "Yes") { lo = true; }
                else if (logon == "No") { lo = false; }
                else { MessageBox.Show("Error Setting 'logon' Variable, Please contact an Administrator, Set Variable to FALSE"); }
                debug.AppendText(System.Environment.NewLine + "<Enabled>" + lo + "</Enabled>");
                debug.AppendText(System.Environment.NewLine + "<Username>" + username + "</Username>");
                debug.AppendText(System.Environment.NewLine + "</AutoLogon>");
                debug.AppendText(System.Environment.NewLine + "<OOBE>");
                bool he = false; 
                if (eulapage == "Yes") { he = true; }
                else if (eulapage == "No") { he = false; }
                else { MessageBox.Show("Error Setting 'eulapage' Variable, Please contact an Administrator, Set Variable to FALSE"); }
                debug.AppendText(System.Environment.NewLine + "<HideEULAPage>" + he + "</HideEULAPage>");
                debug.AppendText(System.Environment.NewLine + "<HideOEMRegistrationScreen>true</HideOEMRegistrationScreen>");
                debug.AppendText(System.Environment.NewLine + "<HideOnlineAccountScreens>true</HideOnlineAccountScreens>");
                bool wo = false;
                if (wireless_oobe == "Yes") { wo = true; }
                else if (wireless_oobe == "No") { wo = false; }
                else { MessageBox.Show("Error Setting 'wireless_oobe' Variable, Please contact an Administrator, Set Variable to FALSE"); }
                debug.AppendText(System.Environment.NewLine + "<HideWirelessSetupInOOBE>" + wo + "</HideWirelessSetupInOOBE>");
                debug.AppendText(System.Environment.NewLine + "<NetworkLocation>" + networklocation + "</NetworkLocation>");
                bool uo = false;
                if (user_oobe == "Yes") { uo = true; }
                else if (user_oobe == "No") { uo = false; }
                else { MessageBox.Show("Error Setting 'user_oobe' Variable, Please contact an Administrator, Set Variable to FALSE"); }
                debug.AppendText(System.Environment.NewLine + "<SkipUserOOBE>" + uo + "</SkipUserOOBE>");
                bool mo = false; ;
                if (machine_oobe == "Yes") { mo = true; }
                else if (machine_oobe == "No") { mo = false; }
                else { MessageBox.Show("Error Setting 'machine_oobe' Variable, Please contact an Administrator, Set Variable to FALSE"); }
                debug.AppendText(System.Environment.NewLine + "<SkipMachineOOBE>" + mo + "</SkipMachineOOBE>");
                int es = 0;
                if (express == "On") { es = 1; }
                else if (express == "Off") { es = 0; }
                else { MessageBox.Show("Error Setting 'express' Variable, Please contact an Administrator, Set Variable to OFF"); }
                debug.AppendText(System.Environment.NewLine + "<ProtectYourPC>" + es + "</ProtectYourPC>");
                debug.AppendText(System.Environment.NewLine + "</OOBE>");
                debug.AppendText(System.Environment.NewLine + "<UserAccounts>");
                debug.AppendText(System.Environment.NewLine + "<LocalAccounts>");
                debug.AppendText(System.Environment.NewLine + "<LocalAccount wcm:action='add'>");
                debug.AppendText(System.Environment.NewLine + "<Password>");
                debug.AppendText(System.Environment.NewLine + "<Value>" + optpwd + "</Value>");
                debug.AppendText(System.Environment.NewLine + "<PlainText>true</PlainText>");
                debug.AppendText(System.Environment.NewLine + "</Password>");
                debug.AppendText(System.Environment.NewLine + "<Description>" + desc + "</Description>");
                debug.AppendText(System.Environment.NewLine + "<DisplayName>" + username + "</DisplayName>");
                debug.AppendText(System.Environment.NewLine + "<Group>" + group + "</Group>");
                debug.AppendText(System.Environment.NewLine + "<Name>" + username + "</Name>");
                debug.AppendText(System.Environment.NewLine + "</LocalAccount>");
                debug.AppendText(System.Environment.NewLine + "</LocalAccounts>");
                debug.AppendText(System.Environment.NewLine + "</UserAccounts>");
                debug.AppendText(System.Environment.NewLine + "<RegisteredOrganization>" + orgname + "</RegisteredOrganization>");
                debug.AppendText(System.Environment.NewLine + "<RegisteredOwner>" + username + "</RegisteredOwner>");
                bool dadt = false;
                if (daylight_timeset == "Yes") { dadt = true; }
                else if (daylight_timeset == "No") { dadt = false; }
                else { MessageBox.Show("Error Setting 'daylight_timeset' Variable, Please contact an Administrator, Set Variable to FALSE"); }
                debug.AppendText(System.Environment.NewLine + "<DisableAutoDaylightTimeSet>" + dadt + "</DisableAutoDaylightTimeSet>");
                debug.AppendText(System.Environment.NewLine + "<FirstLogonCommands>");
                debug.AppendText(System.Environment.NewLine + "<SynchronousCommand wcm:action='add'>");
                debug.AppendText(System.Environment.NewLine + "<Description>Control Panel View</Description>");
                debug.AppendText(System.Environment.NewLine + "<Order>1</Order>");
                debug.AppendText(System.Environment.NewLine + @"<CommandLine>reg add 'HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel' /v StartupPage /t REG_DWORD /d 1 /f</CommandLine>");
                debug.AppendText(System.Environment.NewLine + "<RequiresUserInput>true</RequiresUserInput>");
                debug.AppendText(System.Environment.NewLine + "</SynchronousCommand>");
                debug.AppendText(System.Environment.NewLine + "<SynchronousCommand wcm:action='add'>");
                debug.AppendText(System.Environment.NewLine + "<Order>2</Order>");
                debug.AppendText(System.Environment.NewLine + "<Description>Control Panel Icon Size</Description>");
                debug.AppendText(System.Environment.NewLine + "<RequiresUserInput>false</RequiresUserInput>");
                debug.AppendText(System.Environment.NewLine + @"<CommandLine>reg add 'HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\ControlPanel' /v AllItemsIconView /t REG_DWORD /d 0 /f</CommandLine>");
                debug.AppendText(System.Environment.NewLine + "</SynchronousCommand>");
                debug.AppendText(System.Environment.NewLine + "<SynchronousCommand wcm:action='add'>");
                debug.AppendText(System.Environment.NewLine + "<Order>3</Order>");
                debug.AppendText(System.Environment.NewLine + "<RequiresUserInput>false</RequiresUserInput>");
                debug.AppendText(System.Environment.NewLine + "<CommandLine>cmd /C wmic useraccount where name='" + username + "' set PasswordExpires=" + expires + "</CommandLine>");
                debug.AppendText(System.Environment.NewLine + "<Description>Password Never Expires</Description>");
                debug.AppendText(System.Environment.NewLine + "</SynchronousCommand>");
                debug.AppendText(System.Environment.NewLine + "</FirstLogonCommands>");
                debug.AppendText(System.Environment.NewLine + "<TimeZone>" + zonetime + "</TimeZone>");
                debug.AppendText(System.Environment.NewLine + "</component>");
                debug.AppendText(System.Environment.NewLine + "</settings>");
                debug.AppendText(System.Environment.NewLine + "</unattend>");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            i--;
            switch (i)
            {
                case 5:
                    // Unload Page 6
                    confirmation.Visible = false;
                    debug.Visible = false;
                    showcode.Checked = false;
                    showcode.Visible = false;

                    // Load Page 5
                    user_account_hr.Visible = true;
                    user_name_lb.Visible = true;
                    group_lb.Visible = true;
                    description_lb.Visible = true;
                    opt_password_lb.Visible = true;
                    password_expires_lb.Visible = true;
                    auto_logon_lb.Visible = true;
                    uac_lb.Visible = true;
                    ceip_lb.Visible = true;
                    user_name.Visible = true;
                    group_dd.Visible = true;
                    description.Visible = true;
                    opt_password.Visible = true;
                    password_expires_dd.Visible = true;
                    auto_logon_dd.Visible = true;
                    uac_dd.Visible = true;
                    ceip_dd.Visible = true;
                    user_account_hr.Location = new Point(12, 9);
                    user_name_lb.Location = new Point(103, 65);
                    group_lb.Location = new Point(127, 92);
                    description_lb.Location = new Point(103, 121);
                    opt_password_lb.Location = new Point(64, 190);
                    password_expires_lb.Location = new Point(73, 216);
                    auto_logon_lb.Location = new Point(101, 244);
                    uac_lb.Location = new Point(336, 65);
                    ceip_lb.Location = new Point(334, 92);
                    user_name.Location = new Point(172, 62);
                    group_dd.Location = new Point(172, 89);
                    description.Location = new Point(172, 118);
                    opt_password.Location = new Point(172, 187);
                    password_expires_dd.Location = new Point(172, 213);
                    auto_logon_dd.Location = new Point(172, 241);
                    uac_dd.Location = new Point(374, 61);
                    ceip_dd.Location = new Point(374, 88);

                    // Set Page Number
                    page.Text = i.ToString() + " / " + imax;
                    break;

                case 4:
                    // Unload Page 5
                    user_account_hr.Visible = false;
                    user_name_lb.Visible = false;
                    group_lb.Visible = false;
                    description_lb.Visible = false;
                    opt_password_lb.Visible = false;
                    password_expires_lb.Visible = false;
                    auto_logon_lb.Visible = false;
                    uac_lb.Visible = false;
                    ceip_lb.Visible = false;
                    user_name.Visible = false;
                    group_dd.Visible = false;
                    description.Visible = false;
                    opt_password.Visible = false;
                    password_expires_dd.Visible = false;
                    auto_logon_dd.Visible = false;
                    uac_dd.Visible = false;
                    ceip_dd.Visible = false;

                    // Load Page 4
                    partition_settings_hr.Visible = true;
                    wipe_disk_lb.Visible = true;
                    Install_to_disk_lb.Visible = true;
                    main_partition_active_lb.Visible = true;
                    main_partition_format_lb.Visible = true;
                    main_partition_label_lb.Visible = true;
                    main_partitio_letter_lb.Visible = true;
                    partition_order_lb.Visible = true;
                    wipe_disk_dd.Visible = true;
                    Install_to_disk_dd.Visible = true;
                    main_partition_active_dd.Visible = true;
                    main_partition_format_dd.Visible = true;
                    main_partition_label.Visible = true;
                    main_partition_letter_dd.Visible = true;
                    partition_order_dd.Visible = true;
                    partition_settings_hr.Location = new Point(12, 9);
                    wipe_disk_lb.Location = new Point(107, 65);
                    Install_to_disk_lb.Location = new Point(89, 92);
                    main_partition_active_lb.Location = new Point(59, 121);
                    main_partition_format_lb.Location = new Point(57, 146);
                    main_partition_label_lb.Location = new Point(63, 173);
                    main_partitio_letter_lb.Location = new Point(67, 200);
                    partition_order_lb.Location = new Point(89, 227);
                    wipe_disk_dd.Location = new Point(172, 62);
                    Install_to_disk_dd.Location = new Point(172, 89);
                    main_partition_active_dd.Location = new Point(172, 116);
                    main_partition_format_dd.Location = new Point(172, 143);
                    main_partition_label.Location = new Point(172, 171);
                    main_partition_letter_dd.Location = new Point(172, 197);
                    partition_order_dd.Location = new Point(172, 224);

                    // Set Page Number
                    page.Text = i.ToString() + " / " + imax;
                    break;

                case 3:
                    // Unload Page 4
                    partition_settings_hr.Visible = false;
                    wipe_disk_lb.Visible = false;
                    Install_to_disk_lb.Visible = false;
                    main_partition_active_lb.Visible = false;
                    main_partition_format_lb.Visible = false;
                    main_partition_label_lb.Visible = false;
                    main_partitio_letter_lb.Visible = false;
                    partition_order_lb.Visible = false;
                    wipe_disk_dd.Visible = false;
                    Install_to_disk_dd.Visible = false;
                    main_partition_active_dd.Visible = false;
                    main_partition_format_dd.Visible = false;
                    main_partition_label.Visible = false;
                    main_partition_letter_dd.Visible = false;
                    partition_order_dd.Visible = false;

                    // Load Page 3
                    oobe_hr.Visible = true;
                    network_location_lb.Visible = true;
                    express_settings_lb.Visible = true;
                    hide_eula_lb.Visible = true;
                    disable_auto_daylight_timeset_lb.Visible = true;
                    hide_wireless_setup_in_oobe_lb.Visible = true;
                    skip_machine_oobe_lb.Visible = true;
                    skip_user_oobe_lb.Visible = true;
                    control_panel_view_lb.Visible = true;
                    control_panel_icon_size_lb.Visible = true;
                    network_location_dd.Visible = true;
                    express_settings_dd.Visible = true;
                    hide_eula_dd.Visible = true;
                    disable_auto_daylight_timeset_dd.Visible = true;
                    hide_wireless_setup_in_oobe_dd.Visible = true;
                    skip_machine_oobe_dd.Visible = true;
                    skip_user_oobe_dd.Visible = true;
                    control_panel_view_dd.Visible = true;
                    control_panel_icon_size_dd.Visible = true;
                    oobe_hr.Location = new Point(12, 9);
                    network_location_lb.Location = new Point(62, 49);
                    express_settings_lb.Location = new Point(68, 76);
                    hide_eula_lb.Location = new Point(66, 103);
                    disable_auto_daylight_timeset_lb.Location = new Point(13, 130);
                    hide_wireless_setup_in_oobe_lb.Location = new Point(11, 157);
                    skip_machine_oobe_lb.Location = new Point(49, 184);
                    skip_user_oobe_lb.Location = new Point(69, 211);
                    control_panel_view_lb.Location = new Point(57, 238);
                    control_panel_icon_size_lb.Location = new Point(36, 265);
                    network_location_dd.Location = new Point(162, 46);
                    express_settings_dd.Location = new Point(162, 73);
                    hide_eula_dd.Location = new Point(162, 100);
                    disable_auto_daylight_timeset_dd.Location = new Point(162, 127);
                    hide_wireless_setup_in_oobe_dd.Location = new Point(161, 154);
                    skip_machine_oobe_dd.Location = new Point(162, 181);
                    skip_user_oobe_dd.Location = new Point(162, 208);
                    control_panel_view_dd.Location = new Point(162, 235);
                    control_panel_icon_size_dd.Location = new Point(162, 262);

                    // Set Page Number
                    page.Text = i.ToString() + " / " + imax;
                    break;

                case 2:
                    // Unload Page 3
                    oobe_hr.Visible = false;
                    network_location_lb.Visible = false;
                    express_settings_lb.Visible = false;
                    hide_eula_lb.Visible = false;
                    disable_auto_daylight_timeset_lb.Visible = false;
                    hide_wireless_setup_in_oobe_lb.Visible = false;
                    skip_machine_oobe_lb.Visible = false;
                    skip_user_oobe_lb.Visible = false;
                    control_panel_view_lb.Visible = false;
                    control_panel_icon_size_lb.Visible = false;
                    network_location_dd.Visible = false;
                    express_settings_dd.Visible = false;
                    hide_eula_dd.Visible = false;
                    disable_auto_daylight_timeset_dd.Visible = false;
                    hide_wireless_setup_in_oobe_dd.Visible = false;
                    skip_machine_oobe_dd.Visible = false;
                    skip_user_oobe_dd.Visible = false;
                    control_panel_view_dd.Visible = false;
                    control_panel_icon_size_dd.Visible = false;

                    // Load Page 2
                    back.Visible = true;
                    regional_settings_hr.Visible = true;
                    keyboard_or_input_method_lb.Visible = true;
                    currency_and_date_format_lb.Visible = true;
                    timezone_lb.Visible = true;
                    ui_language_lb.Visible = true;
                    keyboard_or_input_method_dd.Visible = true;
                    currency_and_date_format_dd.Visible = true;
                    timezone_dd.Visible = true;
                    ui_language_dd.Visible = true;
                    tmp_german.Visible = true;
                    tmp_english.Visible = true;
                    tmp_german.Location = new Point(183, 305);
                    tmp_english.Location = new Point(293, 305);
                    regional_settings_hr.Location = new Point(12, 9);
                    keyboard_or_input_method_lb.Location = new Point(23, 65);
                    currency_and_date_format_lb.Location = new Point(23, 103);
                    timezone_lb.Location = new Point(93, 145);
                    ui_language_lb.Location = new Point(82, 189);
                    keyboard_or_input_method_dd.Location = new Point(160, 62);
                    currency_and_date_format_dd.Location = new Point(160, 100);
                    timezone_dd.Location = new Point(160, 142);
                    ui_language_dd.Location = new Point(160, 186);

                    // Set Page Number
                    page.Text = i.ToString() + " / " + imax;
                    break;

                case 1:
                    // Unload Page 2
                    regional_settings_hr.Visible = false;
                    keyboard_or_input_method_lb.Visible = false;
                    currency_and_date_format_lb.Visible = false;
                    timezone_lb.Visible = false;
                    ui_language_lb.Visible = false;
                    keyboard_or_input_method_dd.Visible = false;
                    currency_and_date_format_dd.Visible = false;
                    timezone_dd.Visible = false;
                    ui_language_dd.Visible = false;
                    tmp_german.Visible = false;
                    tmp_english.Visible = false;

                    // Load Page 1
                    back.Visible = false;
                    random.Visible = true;
                    general_settings_hr.Visible = true;
                    bind1.Visible = true;
                    bind2.Visible = true;
                    bind3.Visible = true;
                    bind4.Visible = true;
                    product_key_lb.Visible = true;
                    accept_eula_lb.Visible = true;
                    skip_automatic_activation_lb.Visible = true;
                    skip_license_rearm_lb.Visible = true;
                    setup_language_lb.Visible = true;
                    computername_lb.Visible = true;
                    organisationname_lb.Visible = true;
                    prod_1.Visible = true;
                    prod_2.Visible = true;
                    prod_3.Visible = true;
                    prod_4.Visible = true;
                    prod_5.Visible = true;
                    computername.Visible = true;
                    organisationname.Visible = true;
                    eula_dd.Visible = true;
                    skip_automatic_activation_dd.Visible = true;
                    skip_license_rearm_dd.Visible = true;
                    setup_language_dd.Visible = true;
                    edit_organisationname.Visible = true;
                    general_settings_hr.Location = new Point(12, 9);
                    product_key_lb.Location = new Point(75, 67);
                    prod_1.Location = new Point(149, 64);
                    bind1.Location = new Point(204, 67);
                    prod_2.Location = new Point(220, 64);
                    bind2.Location = new Point(275, 67);
                    prod_3.Location = new Point(291, 64);
                    bind3.Location = new Point(346, 67);
                    prod_4.Location = new Point(362, 64);
                    bind4.Location = new Point(417, 67);
                    prod_5.Location = new Point(433, 64);
                    accept_eula_lb.Location = new Point(75, 100);
                    eula_dd.Location = new Point(149, 97);
                    skip_automatic_activation_lb.Location = new Point(14, 137);
                    skip_automatic_activation_dd.Location = new Point(149, 134);
                    skip_license_rearm_lb.Location = new Point(38, 173);
                    skip_license_rearm_dd.Location = new Point(149, 170);
                    setup_language_lb.Location = new Point(54, 205);
                    setup_language_dd.Location = new Point(149, 202);
                    computername_lb.Location = new Point(57, 238);
                    computername.Location = new Point(149, 235);
                    organisationname_lb.Location = new Point(43, 272);
                    organisationname.Location = new Point(149, 269);
                    edit_organisationname.Location = new Point(285, 269);
                    next.Location = new Point(443, 305);
                    back.Location = new Point(362, 305);
                    page.Location = new Point(13, 308);

                    // Set Page Number
                    page.Text = i.ToString() + " / " + imax;
                    break;

                default:
                    MessageBox.Show("Page " + i + " either doesn't exist or isn't labeled in the Page Index");
                    break;
            }
        }

        private void page_TextChanged(object sender, EventArgs e)
        {
            if (i == imax)
            {
                next.Text = "Generate";
            }
            else
            {
                next.Text = "Next >";
            }
        }

        private void showcode_CheckedChanged(object sender, EventArgs e)
        {
            if (showcode.Checked && confirmation.Visible)
            {
                confirmation.Visible = false;
                debug.Visible = true;
                next.Text = "Save";
            }
            else if (confirmation.Visible || debug.Visible)
            {
                confirmation.Visible = true;
                debug.Visible = false;
                next.Text = "Generate";
            }
        }

        private void tmp_german_CheckedChanged(object sender, EventArgs e)
        {
            if (tmp_german.Checked && tmp_english.Checked == false)
            {
                keyboard_or_input_method_dd.Enabled = false;
                currency_and_date_format_dd.Enabled = false;
                timezone_dd.Enabled = false;
                ui_language_dd.Enabled = false;

                keyboard_or_input_method_dd.SelectedItem = "German - Germany";
                currency_and_date_format_dd.SelectedItem = "German - Germany";
                timezone_dd.SelectedItem = "(UTC+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna";
                ui_language_dd.SelectedItem = "German - Germany";

                tmp_english.Checked = false;
            }
            else if (tmp_english.Checked == false)
            {
                keyboard_or_input_method_dd.Enabled = true;
                currency_and_date_format_dd.Enabled = true;
                timezone_dd.Enabled = true;
                ui_language_dd.Enabled = true;

                keyboard_or_input_method_dd.SelectedItem = "English - United States";
                currency_and_date_format_dd.SelectedItem = "English - United States";
                timezone_dd.SelectedItem = "(UTC-06:00) Central Time (US & Canada)";
                ui_language_dd.SelectedItem = "English - United States";
            }
            else if (tmp_german.Checked)
            {
                tmp_german.Checked = false;
                MessageBox.Show("You cannot enable 2 presets at the same time.");
            }
        }

        private void tmp_english_CheckedChanged(object sender, EventArgs e)
        {
            if (tmp_english.Checked && tmp_german.Checked == false)
            {
                keyboard_or_input_method_dd.Enabled = false;
                currency_and_date_format_dd.Enabled = false;
                timezone_dd.Enabled = false;
                ui_language_dd.Enabled = false;

                keyboard_or_input_method_dd.SelectedItem = "English - United States";
                currency_and_date_format_dd.SelectedItem = "English - United States";
                timezone_dd.SelectedItem = "(UTC-06:00) Central Time (US & Canada)";
                ui_language_dd.SelectedItem = "English - United States";

                tmp_german.Checked = false;
            }
            else if (tmp_german.Checked == false)
            {
                keyboard_or_input_method_dd.Enabled = true;
                currency_and_date_format_dd.Enabled = true;
                timezone_dd.Enabled = true;
                ui_language_dd.Enabled = true;
            }
            else if (tmp_english.Checked)
            {
                tmp_english.Checked = false;
                MessageBox.Show("You cannot enable 2 presets at the same time.");
            }
        }

        private void Generate_FileOk(object sender, CancelEventArgs e)
        {
            // do not remove
        }

        private void random_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int length = 7;
            var rString = "";
            for (int z = 0; z < length; z++)
            {
                rString += ((char)(random.Next(1, 26) + 64)).ToString();
            }
            computername.Text = "PC-" + rString;
        }
    }
}
