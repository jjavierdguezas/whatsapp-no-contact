namespace WhatsappNoContact;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        phoneNumber.Focus();
    }

    async void OnStartChatBtnClicked(object sender, EventArgs e)
    {
        string input = phoneNumber.Text?.Trim();
        if (ValidPhoneNumber(input))
        {
            ChangeEnabled(false);

            // Compute something with the input value
            await Launcher.OpenAsync($"https://wa.me/{input}");

            ChangeEnabled(true);
        }
    }

    bool ValidPhoneNumber(string input) =>
        !string.IsNullOrWhiteSpace(input) &&
        input.Length > 1 &&
        input.Length <= 20 &&
        input.Select((c, idx) => (idx == 0 && c == '+') || char.IsDigit(c)).All(x => x);

    bool ValidPhoneNumberCharacters(string input) =>
        string.IsNullOrEmpty(input) ||
        input[0] == '+' ||
        input.Length <= 20 &&
        input.Select((c, idx) => (idx == 0 && c == '+') || char.IsDigit(c)).All(x => x);

    void ChangeEnabled(bool enabled)
    {
        phoneNumber.IsEnabled = enabled;
        phoneNumber.IsReadOnly = !enabled;
        startChatBtn.IsEnabled = enabled;
    }


    void OnPhoneNumberTextChanged(object sender, TextChangedEventArgs e)
    {
        // Get the new text value
        string newText = e.NewTextValue;

        if (string.IsNullOrEmpty(newText))
        {
            startChatBtn.IsEnabled = false;
            return;
        }

        if (!ValidPhoneNumberCharacters(newText))
        {
            // If the new text value is not valid, revert to the old text value
            phoneNumber.Text = e.OldTextValue;
        }

        startChatBtn.IsEnabled = ValidPhoneNumber(newText);
    }
}
