using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallongeSync
{
    public class Tournament
    {
        public bool accept_attachments;
        public bool allow_participant_match_reporting;
        public bool anonymous_voting;
        public string category;
        public string check_in_duration;
        public DateTime completed_at;
        public DateTime created_at;
        public bool created_by_api;
        public bool credit_capped;
        public string description;
        public int game_id;
        public bool group_stages_enabled;
        public bool hide_forum;
        public bool hide_seeds;
        public bool hold_third_place_match;
        public int id;
        public int max_predictions_per_user;
        public string name;
        public bool notify_users_when_matches_open;
        public bool notify_users_when_the_tournament_ends;
        public bool open_signup;
        public int participants_count;
        public int prediction_method;
        public DateTime predictions_opened_at;
        //bool private;
        public decimal progress_meter;
        public decimal pts_for_bye;
        public decimal pts_for_game_tie;
        public decimal pts_for_game_win;
        public decimal pts_for_match_tie;
        public decimal pts_for_match_win;
        public bool quick_advance;
        public string ranked_by;
        public bool require_score_agreement;
        public decimal rr_pts_for_game_tie;
        public decimal rr_pts_for_game_win;
        public decimal rr_pts_for_match_tie;
        public decimal rr_pts_for_match_win;
        public bool sequential_pairings;
        public bool show_rounds;
        public object signup_cap;
        public DateTime start_at;
        public DateTime started_at;
        public DateTime started_checking_in_at;
        public string state;
        public int swiss_rounds;
        public int teams;
            /*"tie_breaks": [
                "match wins vs tied",
                "game wins",
                "points scored"
            ],*/
        public string tournament_type;
        public DateTime updated_at;
        public string url;
        public string description_source;
        public string subdomain;
        public string full_challonge_url;
        public string live_image_url;
        public string sign_up_url;
        public bool review_before_finalizing;
        public bool accepting_predictions;
        public bool participants_locked;
        public string game_name;
        public bool participants_swappable;
        public bool team_convertable;
        public bool group_stages_were_started;
    }
}
