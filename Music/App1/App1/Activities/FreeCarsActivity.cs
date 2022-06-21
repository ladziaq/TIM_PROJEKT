using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using App1.Adapters;
using App1.Presenters;

namespace App1.Activities
{
    [Activity(Label = "Dostępne pojazdy")]
    public class FreeCarsActivity : AppCompatActivity
    {
        private FreeCarsPresenter presenter;
        public RecyclerView FreeCarsRecyclerView { get; private set; }
        public RentCarAdapter Adapter { get; set; }

        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_free_cars);
            InitalizeViews();
            presenter = await FreeCarsPresenter.CreateAsync(this);

        }

        private void InitalizeViews()
        {
            FreeCarsRecyclerView = FindViewById<RecyclerView>(Resource.Id.freeCarsRV);
            FreeCarsRecyclerView.SetLayoutManager(new LinearLayoutManager(FreeCarsRecyclerView.Context));

     
        }
    }
}
