using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using App1.Adapters;
using App1.Presenters;

namespace App1.Activities
{
    [Activity(Label = "Moje zamówienia")]
    public class MyOrdersActivity : AppCompatActivity
    {
        private MyOrdersPresenter presenter;
        public RecyclerView MyOrdersRecyclerView { get; private set; }
        public MyOrderAdapter Adapter { get; set; }

        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_free_cars);
            InitalizeViews();
            presenter = await MyOrdersPresenter.CreateAsync(this);
            // Create your application here
        }

        private void InitalizeViews()
        {
            MyOrdersRecyclerView = FindViewById<RecyclerView>(Resource.Id.freeCarsRV);
            MyOrdersRecyclerView.SetLayoutManager(new LinearLayoutManager(MyOrdersRecyclerView.Context));

            //adapter = new RentCarAdapter(presenter.Requests);
            //userRV.SetAdapter(adapter);
        }
    }
}
