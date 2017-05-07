using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Fragment = Android.Support.V4.App.Fragment;

namespace Mensarium
{
    public class MainSwapPageAdapter : Android.Support.V4.App.FragmentPagerAdapter
    {
        private Android.Support.V4.App.Fragment[] fragments;
        private ICharSequence[] titles;

        public MainSwapPageAdapter(Android.Support.V4.App.FragmentManager fm, Android.Support.V4.App.Fragment[] fragmets,
            ICharSequence[] titles) : base(fm)
        {
            this.fragments = fragmets;
            this.titles = titles;
        }

        public override int Count { get { return fragments.Length; } }

        public override Fragment GetItem(int position)
        {
            return this.fragments[position];
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {
            return this.titles[position];
        }
    }
}