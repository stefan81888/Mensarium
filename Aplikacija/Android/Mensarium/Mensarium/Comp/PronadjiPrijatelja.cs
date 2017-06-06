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
using Mensarium.Resources.adapters;
using MensariumDesktop.Model.Components.DTOs;

namespace Mensarium.Comp
{
    class PronadjiPrijatelja : Filter
    {
        private readonly MojiPrijateljiAdapter adapter;

        public PronadjiPrijatelja(MojiPrijateljiAdapter a)
        {
            this.adapter = a;
        }

        protected override FilterResults PerformFiltering(ICharSequence constraint)
        {
            var returnObj = new FilterResults();
            var rezultat = new List<KorisnikFollowDto>();

            if (adapter.orgPodaci == null)
                adapter.orgPodaci = adapter.listaPrijatelja;

            if (constraint == null) return returnObj;

            if (adapter.orgPodaci != null && adapter.orgPodaci.Any())
            {
                rezultat.AddRange(
                    adapter.orgPodaci.Where(
                        KorisnikFollowDto => KorisnikFollowDto.Ime.ToLower().Contains(constraint.ToString())));
            }

            returnObj.Values = FromArray(rezultat.Select(r => r.ToJavaObject()).ToArray());
            returnObj.Count = rezultat.Count;

            constraint.Dispose();

            return returnObj;
        }

        protected override void PublishResults(ICharSequence constraint, FilterResults results)
        {
            using (var values = results.Values)
                adapter.listaPrijatelja =
                    values.ToArray<Java.Lang.Object>().Select(r => r.ToNetObject<KorisnikFollowDto>()).ToList();

            adapter.NotifyDataSetChanged();

            constraint.Dispose();
            results.Dispose();
        }
    }
}