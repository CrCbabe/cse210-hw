using System;
using System.Collections.Generic;
class Reference
{
    private string _scripture;
    private int _index;

    static string[] scriptureList = {
        "Isaiah 29:13-14~Wherefore the Lord said, Forasmuch as this people draw near me with their mouth, and with their lips do honour me, but have removed their heart far from me, and their fear toward me is taught by the precept of men: \nTherefore, behold, I will proceed to do a marvellous work among this people, even a marvellous work and a wonder: for the wisdom of their wise men shall perish, and the understanding of their prudent men shall be hid.",
        "Matthew 6:24~No man can serve two masters: for either he will hate the one, and love the other; or else he will hold to the one, and despise the other. Ye cannot serve God and mammon.",
        "Mosiah 3:19~For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.",
        "Doctrine & Covenants 82:10~I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise.",
    };

    List<string> _scriptures = new List<string>(scriptureList);
    public string ChooseScripture()
    {
        Random rand = new Random();
        _index = rand.Next(_scriptures.Count);
        _scripture = _scriptures[_index];
        return _scripture;
    }
}