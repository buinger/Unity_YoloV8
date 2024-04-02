//如果好用，请收藏地址，帮忙分享。
using System.Collections.Generic;


namespace com.baidu.ai
{
    public class Location
    {
        /// <summary>
        /// 
        /// </summary>
        public double left { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double top { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long rotation { get; set; }
    }

    public class Angle
    {
        /// <summary>
        /// 
        /// </summary>
        public double yaw { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double pitch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double roll { get; set; }
    }

    public class Expression
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double probability { get; set; }
    }

    public class Face_shape
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double probability { get; set; }
    }

    public class Gender
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double probability { get; set; }
    }

    public class Glasses
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double probability { get; set; }
    }

    public class LandmarkItem
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Landmark72Item
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_right_1
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_right_3
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_right_5
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_right_7
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_right_9
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_right_11
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Chin_2
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_left_11
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_left_9
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_left_7
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_left_5
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_left_3
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_left_1
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_corner_right
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_eyelid_upper_2
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_eyelid_upper_4
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_eyelid_upper_6
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_corner_left
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_eyelid_lower_6
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_eyelid_lower_4
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_eyelid_lower_2
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_eyeball_center
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_right_corner_right
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_right_upper_2
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_right_upper_3
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_right_upper_4
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_right_corner_left
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_right_lower_3
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_right_lower_2
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_right_lower_1
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_corner_right
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_eyelid_upper_2
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_eyelid_upper_4
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_eyelid_upper_6
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_corner_left
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_eyelid_lower_6
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_eyelid_lower_4
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_eyelid_lower_2
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_eyeball_center
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_left_corner_right
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_left_upper_2
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_left_upper_3
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_left_upper_4
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_left_corner_left
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_left_lower_3
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_left_lower_2
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_left_lower_1
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_right_contour_1
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_right_contour_2
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_right_contour_3
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_right_contour_4
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_right_contour_6
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_left_contour_6
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_left_contour_4
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_left_contour_3
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_left_contour_2
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_left_contour_1
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_tip
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_corner_right_outer
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_outer_3
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_outer_6
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_outer_9
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_corner_left_outer
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_outer_9
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_outer_6
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_outer_3
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_inner_3
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_inner_6
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_inner_9
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_inner_9
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_inner_6
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_inner_3
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_right_2
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_right_4
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_right_6
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_right_8
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_right_10
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Chin_1
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Chin_3
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_left_10
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_left_8
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_left_6
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_left_4
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Cheek_left_2
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_right_upper_1
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_right_upper_5
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_left_upper_1
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eyebrow_left_upper_5
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_eyelid_upper_1
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_eyelid_upper_3
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_eyelid_upper_5
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_eyelid_upper_7
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_eyelid_lower_7
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_eyelid_lower_5
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_eyelid_lower_3
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_eyelid_lower_1
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_eyeball_right
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_right_eyeball_left
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_eyelid_upper_1
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_eyelid_upper_3
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_eyelid_upper_5
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_eyelid_upper_7
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_eyelid_lower_7
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_eyelid_lower_5
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_eyelid_lower_3
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_eyelid_lower_1
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_eyeball_right
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Eye_left_eyeball_left
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_bridge_1
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_bridge_2
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_bridge_3
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_right_contour_5
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_right_contour_7
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_left_contour_7
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_left_contour_5
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Nose_middle_contour
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_corner_right_inner
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_corner_left_inner
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_outer_1
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_outer_2
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_outer_4
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_outer_5
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_outer_7
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_outer_8
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_outer_10
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_outer_11
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_outer_11
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_outer_10
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_outer_8
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_outer_7
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_outer_5
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_outer_4
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_outer_2
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_outer_1
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_inner_1
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_inner_2
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_inner_4
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_inner_5
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_inner_7
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_inner_8
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_inner_10
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_upper_inner_11
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_inner_11
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_inner_10
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_inner_8
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_inner_7
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_inner_5
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_inner_4
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_inner_2
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Mouth_lip_lower_inner_1
    {
        /// <summary>
        /// 
        /// </summary>
        public double x { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double y { get; set; }
    }

    public class Landmark150
    {
        /// <summary>
        /// 
        /// </summary>
        public Cheek_right_1 cheek_right_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_right_3 cheek_right_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_right_5 cheek_right_5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_right_7 cheek_right_7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_right_9 cheek_right_9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_right_11 cheek_right_11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Chin_2 chin_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_left_11 cheek_left_11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_left_9 cheek_left_9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_left_7 cheek_left_7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_left_5 cheek_left_5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_left_3 cheek_left_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_left_1 cheek_left_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_corner_right eye_right_corner_right { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_eyelid_upper_2 eye_right_eyelid_upper_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_eyelid_upper_4 eye_right_eyelid_upper_4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_eyelid_upper_6 eye_right_eyelid_upper_6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_corner_left eye_right_corner_left { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_eyelid_lower_6 eye_right_eyelid_lower_6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_eyelid_lower_4 eye_right_eyelid_lower_4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_eyelid_lower_2 eye_right_eyelid_lower_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_eyeball_center eye_right_eyeball_center { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_right_corner_right eyebrow_right_corner_right { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_right_upper_2 eyebrow_right_upper_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_right_upper_3 eyebrow_right_upper_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_right_upper_4 eyebrow_right_upper_4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_right_corner_left eyebrow_right_corner_left { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_right_lower_3 eyebrow_right_lower_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_right_lower_2 eyebrow_right_lower_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_right_lower_1 eyebrow_right_lower_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_corner_right eye_left_corner_right { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_eyelid_upper_2 eye_left_eyelid_upper_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_eyelid_upper_4 eye_left_eyelid_upper_4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_eyelid_upper_6 eye_left_eyelid_upper_6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_corner_left eye_left_corner_left { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_eyelid_lower_6 eye_left_eyelid_lower_6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_eyelid_lower_4 eye_left_eyelid_lower_4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_eyelid_lower_2 eye_left_eyelid_lower_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_eyeball_center eye_left_eyeball_center { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_left_corner_right eyebrow_left_corner_right { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_left_upper_2 eyebrow_left_upper_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_left_upper_3 eyebrow_left_upper_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_left_upper_4 eyebrow_left_upper_4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_left_corner_left eyebrow_left_corner_left { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_left_lower_3 eyebrow_left_lower_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_left_lower_2 eyebrow_left_lower_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_left_lower_1 eyebrow_left_lower_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_right_contour_1 nose_right_contour_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_right_contour_2 nose_right_contour_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_right_contour_3 nose_right_contour_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_right_contour_4 nose_right_contour_4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_right_contour_6 nose_right_contour_6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_left_contour_6 nose_left_contour_6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_left_contour_4 nose_left_contour_4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_left_contour_3 nose_left_contour_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_left_contour_2 nose_left_contour_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_left_contour_1 nose_left_contour_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_tip nose_tip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_corner_right_outer mouth_corner_right_outer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_outer_3 mouth_lip_upper_outer_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_outer_6 mouth_lip_upper_outer_6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_outer_9 mouth_lip_upper_outer_9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_corner_left_outer mouth_corner_left_outer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_outer_9 mouth_lip_lower_outer_9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_outer_6 mouth_lip_lower_outer_6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_outer_3 mouth_lip_lower_outer_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_inner_3 mouth_lip_upper_inner_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_inner_6 mouth_lip_upper_inner_6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_inner_9 mouth_lip_upper_inner_9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_inner_9 mouth_lip_lower_inner_9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_inner_6 mouth_lip_lower_inner_6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_inner_3 mouth_lip_lower_inner_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_right_2 cheek_right_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_right_4 cheek_right_4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_right_6 cheek_right_6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_right_8 cheek_right_8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_right_10 cheek_right_10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Chin_1 chin_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Chin_3 chin_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_left_10 cheek_left_10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_left_8 cheek_left_8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_left_6 cheek_left_6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_left_4 cheek_left_4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Cheek_left_2 cheek_left_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_right_upper_1 eyebrow_right_upper_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_right_upper_5 eyebrow_right_upper_5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_left_upper_1 eyebrow_left_upper_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eyebrow_left_upper_5 eyebrow_left_upper_5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_eyelid_upper_1 eye_right_eyelid_upper_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_eyelid_upper_3 eye_right_eyelid_upper_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_eyelid_upper_5 eye_right_eyelid_upper_5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_eyelid_upper_7 eye_right_eyelid_upper_7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_eyelid_lower_7 eye_right_eyelid_lower_7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_eyelid_lower_5 eye_right_eyelid_lower_5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_eyelid_lower_3 eye_right_eyelid_lower_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_eyelid_lower_1 eye_right_eyelid_lower_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_eyeball_right eye_right_eyeball_right { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_right_eyeball_left eye_right_eyeball_left { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_eyelid_upper_1 eye_left_eyelid_upper_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_eyelid_upper_3 eye_left_eyelid_upper_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_eyelid_upper_5 eye_left_eyelid_upper_5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_eyelid_upper_7 eye_left_eyelid_upper_7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_eyelid_lower_7 eye_left_eyelid_lower_7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_eyelid_lower_5 eye_left_eyelid_lower_5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_eyelid_lower_3 eye_left_eyelid_lower_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_eyelid_lower_1 eye_left_eyelid_lower_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_eyeball_right eye_left_eyeball_right { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_left_eyeball_left eye_left_eyeball_left { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_bridge_1 nose_bridge_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_bridge_2 nose_bridge_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_bridge_3 nose_bridge_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_right_contour_5 nose_right_contour_5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_right_contour_7 nose_right_contour_7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_left_contour_7 nose_left_contour_7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_left_contour_5 nose_left_contour_5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nose_middle_contour nose_middle_contour { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_corner_right_inner mouth_corner_right_inner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_corner_left_inner mouth_corner_left_inner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_outer_1 mouth_lip_upper_outer_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_outer_2 mouth_lip_upper_outer_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_outer_4 mouth_lip_upper_outer_4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_outer_5 mouth_lip_upper_outer_5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_outer_7 mouth_lip_upper_outer_7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_outer_8 mouth_lip_upper_outer_8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_outer_10 mouth_lip_upper_outer_10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_outer_11 mouth_lip_upper_outer_11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_outer_11 mouth_lip_lower_outer_11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_outer_10 mouth_lip_lower_outer_10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_outer_8 mouth_lip_lower_outer_8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_outer_7 mouth_lip_lower_outer_7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_outer_5 mouth_lip_lower_outer_5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_outer_4 mouth_lip_lower_outer_4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_outer_2 mouth_lip_lower_outer_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_outer_1 mouth_lip_lower_outer_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_inner_1 mouth_lip_upper_inner_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_inner_2 mouth_lip_upper_inner_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_inner_4 mouth_lip_upper_inner_4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_inner_5 mouth_lip_upper_inner_5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_inner_7 mouth_lip_upper_inner_7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_inner_8 mouth_lip_upper_inner_8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_inner_10 mouth_lip_upper_inner_10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_upper_inner_11 mouth_lip_upper_inner_11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_inner_11 mouth_lip_lower_inner_11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_inner_10 mouth_lip_lower_inner_10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_inner_8 mouth_lip_lower_inner_8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_inner_7 mouth_lip_lower_inner_7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_inner_5 mouth_lip_lower_inner_5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_inner_4 mouth_lip_lower_inner_4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_inner_2 mouth_lip_lower_inner_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mouth_lip_lower_inner_1 mouth_lip_lower_inner_1 { get; set; }
    }

    public class Race
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double probability { get; set; }
    }

    public class Occlusion
    {
        /// <summary>
        /// 
        /// </summary>
        public double left_eye { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double right_eye { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double nose { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double mouth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double left_cheek { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double right_cheek { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double chin_contour { get; set; }
    }

    public class Quality
    {
        /// <summary>
        /// 
        /// </summary>
        public Occlusion occlusion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double blur { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double illumination { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long completeness { get; set; }
    }

    public class Eye_status
    {
        /// <summary>
        /// 
        /// </summary>
        public double left_eye { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double right_eye { get; set; }
    }

    public class Emotion
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double probability { get; set; }
    }

    public class Face_type
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double probability { get; set; }
    }

    public class Mask
    {
        /// <summary>
        /// 
        /// </summary>
        public int type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double probability { get; set; }
    }

    public class Face_listItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string face_token { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Location location { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double face_probability { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Angle angle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double age { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long beauty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Expression expression { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Face_shape face_shape { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Gender gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Glasses glasses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<LandmarkItem> landmark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Landmark72Item> landmark72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Landmark150 landmark150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Race race { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Quality quality { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Eye_status eye_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Emotion emotion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Face_type face_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mask mask { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double spoofing { get; set; }
    }

    public class Result
    {
        /// <summary>
        /// 
        /// </summary>
        public int face_num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Face_listItem> face_list { get; set; }
    }

    public class AllFaceInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public int error_code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string error_msg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public long log_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int timestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int cached { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Result result { get; set; }
    }
}