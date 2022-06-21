using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using App1.Adapters;
using App1.Presenters;

namespace App1.Activities
{
    [Activity(Label = "Wszystkie pojazdy")]
    public class AllCarsActivity : AppCompatActivity
    {
        private AllCarsPresenter presenter;
        public RecyclerView AllCarsRecyclerView { get; private set; }
        public AdminCarAdapter Adapter { get; set; }

        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_free_cars);
            InitalizeViews();
            presenter = await AllCarsPresenter.CreateAsync(this);
        }

        private void InitalizeViews()
        {
            AllCarsRecyclerView = FindViewById<RecyclerView>(Resource.Id.freeCarsRV);
            AllCarsRecyclerView.SetLayoutManager(new LinearLayoutManager(AllCarsRecyclerView.Context));
        }
    }
}
