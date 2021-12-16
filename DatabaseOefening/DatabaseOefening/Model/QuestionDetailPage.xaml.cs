using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatabaseOefening.Model
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionDetailPage : ContentPage
    {
        Question question;
        public QuestionDetailPage(Question selectedQuestion)
        {
            InitializeComponent();
            question = selectedQuestion;

            IdLabel.Text = question.Id.ToString();
            QuestionBodyEntry.Text = question.QuestionBody;
        }


        private async  void UpdateButton_Clicked(object sender, EventArgs e)
        {
            int updateRows;
            question.QuestionBody = QuestionBodyEntry.Text;


            using (SQLiteConnection sQLiteConnection = new SQLiteConnection(App.DatabaseLocation))
            {
                sQLiteConnection.CreateTable<Question>();
                updateRows = sQLiteConnection.Update(question);
            }

            if (updateRows > 0)
            {
                _ = DisplayAlert("Gelukt", "Je vraag is goed aangepast.", "ok");

            }
            else
            {
                _ = DisplayAlert("Ah, jammer! Er gong iets fout.", "Je vraag is niet aangepast.", "ok");
            }




            await Navigation.PopAsync();
        }

        private async void DeleteButton_Clicked(object sender, EventArgs e)
        {
            int deleteRows;
            question.QuestionBody = QuestionBodyEntry.Text;

            using (SQLiteConnection sQLiteConnection = new SQLiteConnection(App.DatabaseLocation))
            {
                sQLiteConnection.CreateTable<Question>();
                deleteRows = sQLiteConnection.Delete(question);
            }

            if (deleteRows > 0)
            {
                _ = DisplayAlert("Gelukt", "Je vraag is verwijderd.", "ok");
            }
            else
            {
                _ = DisplayAlert("Ah, jammer! Er ging iets fout", "Je vraag is niet verwijderd.", "ok");
            }




            await Navigation.PopAsync();
        }
    }
}