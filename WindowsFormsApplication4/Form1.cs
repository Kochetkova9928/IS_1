using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication4
{

    public enum Category
    {
        Economical,
        Middle,
        Brand,
        Specialized,
        Any
    }

    public partial class Form1 : Form
    {
        private Model model;
        private Category category;
        public Form1()
        {
            InitializeComponent();
            model = new Model();
            CategoryComboBox.Items.Add(GetName(Category.Economical));
            CategoryComboBox.Items.Add(GetName(Category.Middle));
            CategoryComboBox.Items.Add(GetName(Category.Brand));
            CategoryComboBox.Items.Add(GetName(Category.Specialized));
            CategoryComboBox.Items.Add(GetName(Category.Any));

            CategoryComboBox.SelectedIndex = 4;

            category = Category.Any;
            ChangeCategory(category);
        }

        public string GetName(Category category)
        {
            switch (category)
            {
                case Category.Economical: return "Бюджетный ценовой сегмент";
                case Category.Middle: return "Средний ценовой сегмент";
                case Category.Brand: return "Брендовые модели";
                case Category.Specialized: return "Специализированные модели";
                case Category.Any: return "Все модели";
            }

            return "";
        }

        public Category GetCategory(string name)
        {
            switch (name)
            {
                case "Бюджетный ценовой сегмент": return Category.Economical;
                case "Средний ценовой сегмент": return Category.Middle;
                case "Брендовые модели": return Category.Brand;
                case "Специализированные модели": return Category.Specialized;
                case "Все модели": return Category.Any;
            }

            return Category.Any;
        }

        // в зависимости от категории обновляем параметры выбора
        private void ChangeCategory(Category c)
        {
            switch (c)
            {
                case Category.Economical:
                    ChangeForEconomical();
                    break;
                case Category.Middle:
                    ChangeForMiddle();
                    break;
                case Category.Brand:
                    ChangeForBrand();
                    break;
                case Category.Specialized:
                    ChangeForSpecialized();
                    break;
                case Category.Any:
                    ChangeForAny();
                    break;
            }

            UpdateAllValues();
            UpdatePhoneList();
        }

        public void ChangeForEconomical()
        {
            category = Category.Economical;
            PriceTrackBar.Enabled = true;
            BatteryCapacityTrackBar.Enabled = true;
            MemoryTrackBar.Enabled = false;
            WeigthTrackBar.Enabled = false;
            CoolFactorTrackBar.Enabled = false;
            ReleaseDateUpDown.Enabled = false;
            IsSpecializedCheckBox.Enabled = false;

            IsSpecializedCheckBox.Checked = false;
        }

        public void ChangeForMiddle()
        {
            category = Category.Middle;
            PriceTrackBar.Enabled = true;
            BatteryCapacityTrackBar.Enabled = true;
            MemoryTrackBar.Enabled = true;
            WeigthTrackBar.Enabled = false;
            CoolFactorTrackBar.Enabled = false;
            ReleaseDateUpDown.Enabled = false;
            IsSpecializedCheckBox.Enabled = false;

            IsSpecializedCheckBox.Checked = false;
        }

        public void ChangeForBrand()
        {
            category = Category.Brand;
            PriceTrackBar.Enabled = true;
            BatteryCapacityTrackBar.Enabled = true;
            MemoryTrackBar.Enabled = true;
            WeigthTrackBar.Enabled = true;
            CoolFactorTrackBar.Enabled = true;
            ReleaseDateUpDown.Enabled = true;
            IsSpecializedCheckBox.Enabled = false;

            IsSpecializedCheckBox.Checked = false;
        }

        public void ChangeForSpecialized()
        {
            category = Category.Specialized;
            PriceTrackBar.Enabled = false;
            BatteryCapacityTrackBar.Enabled = false;
            MemoryTrackBar.Enabled = false;
            WeigthTrackBar.Enabled = false;
            CoolFactorTrackBar.Enabled = false;
            ReleaseDateUpDown.Enabled = false;
            IsSpecializedCheckBox.Enabled = false;

            IsSpecializedCheckBox.Checked = true;
        }

        public void ChangeForAny()
        {
            category = Category.Any;
            PriceTrackBar.Enabled = true;
            BatteryCapacityTrackBar.Enabled = true;
            MemoryTrackBar.Enabled = true;
            WeigthTrackBar.Enabled = true;
            CoolFactorTrackBar.Enabled = true;
            ReleaseDateUpDown.Enabled = true;
            IsSpecializedCheckBox.Enabled = true;

            IsSpecializedCheckBox.Checked = false;
        }

        // обновляем все значения параметров в зависимости от категории
        public void UpdateAllValues()
        {
            var phones = model.Phones;

            switch (category)
            {
                case Category.Economical:
                    phones = phones.Where(x => x.Price <= 10000 && !x.IsSpecialized).ToList();
                    break;
                case Category.Middle:
                    phones = phones.Where(x => 10000 <= x.Price && x.Price <= 30000 && !x.IsSpecialized).ToList();
                    break;
                case Category.Brand:
                    phones = phones.Where(x => 30000 <= x.Price && !x.IsSpecialized).ToList();
                    break;
                case Category.Specialized:
                    phones = phones.Where(x => x.IsSpecialized).ToList();
                    break;
            }

            PriceTrackBar.Minimum = phones.Min(x => x.Price);
            PriceTrackBar.Maximum = phones.Max(x => x.Price);
            PriceTrackBar.Value = PriceTrackBar.Maximum;
            UpdatePriceTrackBarLabel();

            BatteryCapacityTrackBar.Minimum = phones.Min(x => x.BatteryCapacity);
            BatteryCapacityTrackBar.Maximum = phones.Max(x => x.BatteryCapacity);
            BatteryCapacityTrackBar.Value = BatteryCapacityTrackBar.Minimum;
            UpdateBarBatteryCapacityTrackBarLabel();

            MemoryTrackBar.Minimum = phones.Min(x => x.Memory);
            MemoryTrackBar.Maximum = phones.Max(x => x.Memory);
            MemoryTrackBar.Value = MemoryTrackBar.Minimum;
            UpdateMemoryTrackBarLabel();

            WeigthTrackBar.Minimum = phones.Min(x => x.Weight);
            WeigthTrackBar.Maximum = phones.Max(x => x.Weight);
            WeigthTrackBar.Value = WeigthTrackBar.Maximum;
            UpdateWeightTrackBarLabel();

            CoolFactorTrackBar.Minimum = phones.Min(x => x.CoolFactor);
            CoolFactorTrackBar.Maximum = phones.Max(x => x.CoolFactor);
            CoolFactorTrackBar.Value = CoolFactorTrackBar.Minimum;
            UpdateCoolFactorTrackBarLabel();

            ReleaseDateUpDown.Minimum = phones.Min(x => x.ReleaseDate.Year);
            ReleaseDateUpDown.Maximum = phones.Max(x => x.ReleaseDate.Year);
            ReleaseDateUpDown.Value = ReleaseDateUpDown.Minimum;
        }

        // обновляем Label для каждого параметра в зависимости от выбранной категории
        public void UpdatePriceTrackBarLabel()
        {
            CurrentPriceLabel.Text = $"До {PriceTrackBar.Value}";
        }

        public void UpdateBarBatteryCapacityTrackBarLabel()
        {
            CurrentBatteryLabel.Text = $"От {BatteryCapacityTrackBar.Value}";
        }

        public void UpdateMemoryTrackBarLabel()
        {
            CurrentMemoryLabel.Text = $"От {MemoryTrackBar.Value}";
        }

        public void UpdateWeightTrackBarLabel()
        {
            CurrentWeigthLabel.Text = $"До {WeigthTrackBar.Value}";
        }

        public void UpdateCoolFactorTrackBarLabel()
        {
            CurrentCoolFactorLabel.Text = $"От {CoolFactorTrackBar.Value}";
        }

        // обновляем список телефонов в зависимости от такого какие параметры выбрал пользователь
        public void UpdatePhoneList()
        {
            var price = PriceTrackBar.Value;
            var batteryCapacity = BatteryCapacityTrackBar.Value;
            var memory = MemoryTrackBar.Value;
            var weight = WeigthTrackBar.Value;
            var coolFactor = CoolFactorTrackBar.Value;
            var year = ReleaseDateUpDown.Value;
            var isSpecialized = IsSpecializedCheckBox.Checked;

            var phones = model.Phones.Where(x =>
                x.Price <= price &&
                x.BatteryCapacity >= batteryCapacity &&
                x.Memory >= memory &&
                x.Weight <= weight &&
                x.CoolFactor >= coolFactor &&
                x.ReleaseDate.Year >= year &&
                x.IsSpecialized == isSpecialized
            );

            PhoneListBox.Items.Clear();
            foreach (var phone in phones.OrderBy(x => x.Name))
            {
                PhoneListBox.Items.Add(phone.Name);
            }

            if (PhoneListBox.SelectedIndex < 0 && PhoneListBox.Items.Count > 0)
            {
                PhoneListBox.SelectedIndex = 0;
            }
        }

        // обновляем все скроллеры (делаем кликабельными или нет), обновляем список подобранных телефонов
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;

            ChangeCategory(GetCategory(comboBox.SelectedItem.ToString()));
        }

        private void PriceTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdatePriceTrackBarLabel();
            UpdatePhoneList();
        }

        private void BatteryCapacityTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateBarBatteryCapacityTrackBarLabel();
            UpdatePhoneList();
        }

        private void MemoryTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateMemoryTrackBarLabel();
            UpdatePhoneList();
        }

        private void WeigthTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateWeightTrackBarLabel();
            UpdatePhoneList();
        }

        private void CoolFactorTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateCoolFactorTrackBarLabel();
            UpdatePhoneList();
        }

        private void ReleaseDateUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdatePhoneList();
        }

        private void IsSpecializedCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            UpdatePhoneList();
        }

        // обновляем лист-бокс "Характеристики выбранной модели"
        private void PhoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var phone = model.Phones.FirstOrDefault(x => x.Name == (string)PhoneListBox.SelectedItem);

            label1.Text = $"Характеристики: {phone.Name}";
            label2.Text = $"Цена: {phone.Price}";
            label3.Text = $"Емкость аккумулятора: {phone.BatteryCapacity}";
            label4.Text = $"Объем внутренней памяти: {phone.Memory}";
            label5.Text = $"Вес: {phone.Weight}";
            label6.Text = $"Фактор крутости: {phone.CoolFactor}";
            label7.Text = $"Дата выхода: {phone.ReleaseDate.Year}";
        }
    }
}
