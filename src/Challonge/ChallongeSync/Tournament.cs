using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallongeSync
{
    public class Tournament
    {
        public bool Accept_attachments { get; set; }
        public bool Allow_participant_match_reporting { get; set; }
        public bool Anonymous_voting { get; set; }
        public string Category { get; set; }
        public string Check_in_duration { get; set; }
        public DateTime Completed_at { get; set; }
        public DateTime Created_at { get; set; }
        public bool Created_by_api { get; set; }
        public bool Credit_capped { get; set; }
        public string Description { get; set; }
        public int Game_id { get; set; }
        public bool Group_stages_enabled { get; set; }
        public bool Hide_forum { get; set; }
        public bool Hide_seeds { get; set; }
        public bool Hold_third_place_match { get; set; }
        public int Id { get; set; }
        public int Max_predictions_per_user { get; set; }
        public string Name {get; set;}
        public bool Notify_users_when_matches_open { get; set; }
        public bool Notify_users_when_the_tournament_ends { get; set; }
        public bool Open_signup { get; set; }
        public int Participants_count { get; set; }
        public int Prediction_method { get; set; }
        public DateTime Predictions_opened_at { get; set; }
        //bool private;
        public decimal Progress_meter { get; set; }
        public decimal Pts_for_bye { get; set; }
        public decimal Pts_for_game_tie { get; set; }
        public decimal pts_for_game_win { get; set; }
        public decimal Pts_for_match_tie { get; set; }
        public decimal Pts_for_match_win { get; set; }
        public bool Quick_advance { get; set; }
        public string Ranked_by { get; set; }
        public bool Require_score_agreement { get; set; }
        public decimal Rr_pts_for_game_tie { get; set; }
        public decimal Rr_pts_for_game_win { get; set; }
        public decimal Rr_pts_for_match_tie { get; set; }
        public decimal Rr_pts_for_match_win { get; set; }
        public bool Sequential_pairings { get; set; }
        public bool Show_rounds { get; set; }
        public object Signup_cap { get; set; }
        public DateTime Start_at { get; set; }
        public DateTime Started_at { get; set; }
        public DateTime Started_checking_in_at { get; set; }
        public string State { get; set; }
        public int Swiss_rounds { get; set; }
        public int Teams { get; set; }
            /*"tie_breaks": [
                "match wins vs tied",
                "game wins",
                "points scored"
            ],*/
        public string Tournament_type { get; set; }
        public DateTime Updated_at { get; set; }
        public string Url { get; set; }
        public string Description_source { get; set; }
        public string Subdomain { get; set; }
        public string Full_challonge_url { get; set; }
        public string Live_image_url { get; set; }
        public string Sign_up_url { get; set; }
        public bool Review_before_finalizing { get; set; }
        public bool Accepting_predictions { get; set; }
        public bool Participants_locked { get; set; }
        public string Game_name { get; set; }
        public bool Participants_swappable { get; set; }
        public bool Team_convertable { get; set; }
        public bool Group_stages_were_started { get; set; }
    }
}
