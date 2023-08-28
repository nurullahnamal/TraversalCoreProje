namespace TraversalCoreProje.Areas.Admin.Models
{
    public class HotelsSearchViewModel
    {



        
            public Datum[] data { get; set; }
            public Status status { get; set; }
            public Paging paging { get; set; }
        

        public class Status
        {
            public string unfiltered_total_size { get; set; }
            public string commerce_country_iso_code { get; set; }
            public bool autobroadened { get; set; }
            public string progress { get; set; }
            public string auction_key { get; set; }
            public string primary_geo { get; set; }
            public string pricing { get; set; }
            public string doubleClickZone { get; set; }
        }

        public class Paging
        {
            public string results { get; set; }
            public string total_results { get; set; }
        }

        public class Datum
        {
            public string location_id { get; set; }
            public string name { get; set; }
            public string latitude { get; set; }
            public string longitude { get; set; }
            public string num_reviews { get; set; }
            public string timezone { get; set; }
            public string location_string { get; set; }
            public object[] awards { get; set; }
            public string preferred_map_engine { get; set; }
            public string autobroaden_type { get; set; }
            public string autobroaden_label { get; set; }
            public string ranking_position { get; set; }
            public string ranking_denominator { get; set; }
            public string ranking { get; set; }
            public string distance { get; set; }
            public object distance_string { get; set; }
            public string bearing { get; set; }
            public bool is_closed { get; set; }
            public bool is_long_closed { get; set; }
            public string price_level { get; set; }
            public string hotel_class { get; set; }
            public Business_Listings business_listings { get; set; }
            public Special_Offers special_offers { get; set; }
            public string listing_key { get; set; }
            public Photo photo { get; set; }
            public string raw_ranking { get; set; }
            public string ranking_geo { get; set; }
            public string ranking_geo_id { get; set; }
            public string ranking_category { get; set; }
            public string subcategory_type { get; set; }
            public string subcategory_type_label { get; set; }
            public string rating { get; set; }
            public string price { get; set; }
            public string hotel_class_attribution { get; set; }
            public string ad_position { get; set; }
            public string ad_size { get; set; }
            public string doubleclick_zone { get; set; }
            public Ancestor[] ancestors { get; set; }
            public string detail { get; set; }
            public string page_type { get; set; }
            public string mob_ptype { get; set; }
        }

        public class Business_Listings
        {
            public object[] desktop_contacts { get; set; }
            public object[] mobile_contacts { get; set; }
        }

        public class Special_Offers
        {
            public object[] desktop { get; set; }
            public object[] mobile { get; set; }
        }

        public class Photo
        {
            public Images images { get; set; }
            public bool is_blessed { get; set; }
            public DateTime uploaded_date { get; set; }
            public string caption { get; set; }
            public string id { get; set; }
            public string helpful_votes { get; set; }
            public DateTime published_date { get; set; }
            public User user { get; set; }
        }

        public class Images
        {
            public Small small { get; set; }
            public Thumbnail thumbnail { get; set; }
            public Original original { get; set; }
            public Large large { get; set; }
            public Medium medium { get; set; }
        }

        public class Small
        {
            public string width { get; set; }
            public string url { get; set; }
            public string height { get; set; }
        }

        public class Thumbnail
        {
            public string width { get; set; }
            public string url { get; set; }
            public string height { get; set; }
        }

        public class Original
        {
            public string width { get; set; }
            public string url { get; set; }
            public string height { get; set; }
        }

        public class Large
        {
            public string width { get; set; }
            public string url { get; set; }
            public string height { get; set; }
        }

        public class Medium
        {
            public string width { get; set; }
            public string url { get; set; }
            public string height { get; set; }
        }

        public class User
        {
            public object user_id { get; set; }
            public string member_id { get; set; }
            public string type { get; set; }
        }

        public class Ancestor
        {
            public Subcategory[] subcategory { get; set; }
            public string name { get; set; }
            public object abbrv { get; set; }
            public string location_id { get; set; }
        }

        public class Subcategory
        {
            public string key { get; set; }
            public string name { get; set; }
        }




    }
}


