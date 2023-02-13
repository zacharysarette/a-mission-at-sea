Boat Party
-> start

=== start ===
Honoka arrived at the boat party, her mind already focused on her mission: obtain the key to the organization's secret safe. 
She scanned the crowd, trying to find any leads to her target, the merchant Wantanabe Kenji. 

* Look for Kenji
    Honoka's eyes searched the crowd, until they finally landed on a man in a tailored suit, surrounded by admirers.
    He had to be Kenji.
    -> approach
* Explore other rooms
    Honoka decided to take a closer look around the boat, perhaps there were clues to be found elsewhere.
    -> other_rooms

=== approach ===
Honoka made her way towards Kenji, her heart pounding with a mixture of fear and excitement. She was well aware of his reputation as a dangerous man. 
As she approached him, Kenji turned and their eyes met. 

* Smile and introduce yourself
    Honoka put on her most charming smile and approached Kenji, hand extended. "Hello, I'm Honoka."
    -> introduce
* Try to overhear Kenji's conversation
    Honoka hung back, trying to overhear Kenji's conversation and gather any useful information.
    -> overhear

=== introduce ===
Kenji looked at Honoka with a raised eyebrow. "Honoka, is it? And what brings you to this boat party?"

* Play it cool
    Honoka played it cool, sipping her drink and making small talk with Kenji. "I heard this was the party to be at, and I just had to see for myself."
    -> play_it_cool
* Be straightforward
    Honoka decided to be straightforward with Kenji. "I'm here for the key, Kenji. I know what you have, and I need it."
    -> be_straightforward

=== play_it_cool ===
Honoka and Kenji chatted for a while, their conversation ranging from the weather to the latest gossip. 
As the night went on, Honoka tried to steer the conversation towards the key, hoping to gather more information about it. 

* Ask about the key
    "So, Kenji, I heard you have something valuable on this boat," Honoka said, trying to sound casual. "A key, perhaps?"
    -> ask_key
* Wait for the right moment
    Honoka decided to bide her time, waiting for the right moment to bring up the key.
    -> wait

=== ask_key ===
Kenji's eyes narrowed. "Who told you that?" he asked, his voice low and dangerous.

* Lie
    Honoka quickly thought of a lie. "Oh, just a rumor I heard around town," she said with a shrug.
    -> lie
* Tell the truth
    Honoka decided to be honest with Kenji. "I work for an organization that needs that key, Kenji. I need it for a mission."
    -> tell_truth

=== lie ===
Kenji didn't seem convinced by Honoka's lie. He studied her for a moment before speaking. 
"I don't like people who lie to me, Honoka. You should leave."
-> END

=== tell_truth ===
Kenji's eyes softened. "I see. Well, Honoka, if you're here for the key, you're out of luck. It's not for sale."
-> END

=== overhear ===
* "What are you talking about?" I ask, trying to appear nonchalant as I approach the two men.
    Kenji and the other man turn to look at me.
    "Ah, a new face. You must be a party-goer, yes?" Kenji says with a sly grin.

->DONE
* "Yes, I'm here for the party. What's the discussion about?" I reply, trying to get closer.
"Just business," Kenji says dismissively, taking a step back. "Nothing for a young lady like yourself to worry about."

->DONE
* "I couldn't help but overhear," I persist, a hint of steel in my voice. "And I think I might be able to help with your business dealings."
Kenji raises an eyebrow, intrigued. "Really? And who might you be?"
"My name is Honoka," I say smoothly. "I am a private investigator."

->DONE
* "I see. And what exactly do you think you can help us with?" Kenji asks, still skeptical.
"I have connections and resources that could be useful to you. And I also have a keen sense for when something isn't quite right," I reply, keeping my gaze steady.

    "Well, Miss Honoka," Kenji says, sizing me up. "Perhaps we do have some use for someone with your skills. But I must caution you, this is dangerous work. Are you prepared for that?"

->DONE
* "Yes, I'm ready for anything," I say confidently. "I can handle danger."
    "Good to hear," Kenji says, nodding. "I'll keep you in mind for future projects. In the meantime, enjoy the party."
->DONE
* "I'm not one to back down from a challenge," I say, holding Kenji's gaze. "I'm ready to prove myself to you now."
Kenji laughs. "Well, you certainly are eager. Very well, Miss Honoka. I have a task that requires a discreet and capable individual. Are you interested?"

->DONE
* "Of course," I reply, feeling a thrill of excitement. "What do you need me to do?"
Kenji leans in close, speaking in a low voice. "I need you to retrieve a key that was stolen from me. The thief is hiding out in one of the other rooms on this boat. Can you find them and retrieve the key?"

->DONE
* "I'll do it," I say firmly. "Just tell me where to start."
Kenji nods. "I have a feeling you're going to be a valuable asset, Honoka. I'll be waiting for your return with the key. Good luck."
-> other_rooms

=== other_rooms ===
* [Look around the other rooms]
	I wandered through the other rooms, trying to find anything of interest. I couldn't see anything useful, just a few guests milling about. 
	-> keep_looking
	
* [Return to Kenji's room]
	I decided to return to Kenji's room, knowing that he was the key to obtaining the information I needed. 	-> back_to_kenji

=== keep_looking ===
* [Look around the room more closely]
	As I looked more closely, I noticed a key hanging from a nearby table. Could this be the key I was looking for?
	-> key_found
	
* [Keep wandering]
	I continued to wander around the room, trying to pick up any information or clues that might be helpful. 
	-> overhear
	
=== key_found ===
* [Take the key]
	I reached over and took the key, feeling a rush of excitement. 
	-> key_obtained
	
* [Leave the key alone]
	I hesitated, not wanting to risk being caught. 
	-> back_to_kenji
	
=== key_obtained ===
-> END

=== back_to_kenji ===
I made my way back to the table, trying to appear nonchalant. 
"I'm sorry, I couldn't find anything," I lied. "Just a storage room." 
Kenji raised an eyebrow, his gaze piercing. 

* Play along with Kenji's suspicions 
  "I don't know what you're talking about." I tried to keep my voice steady. "I was just looking for the restroom."
  Kenji's expression softened. "Ah, I see. Well, let's get back to the party."
  -> end_event 

* Confess to Kenji 
  "I'm actually here on a mission," I admitted. "I work for a rival company and I was sent to steal your key."
  Kenji's expression darkened. "You should have known better than to cross me."
  -> end_event 

=== end_event ===
-> END
=== be_straightforward ===
* "Excuse me, Mr. Kenji." I approached him directly. "I couldn't help but overhear your conversation."
  -> confronted

=== wait ===
* I decided to wait and see if the opportunity presents itself.
  -> bided_time

=== confronted ===
Kenji turned to face me, his expression unreadable.

* "What is it that you want?"
  "I'm interested in your business dealings. I believe I can be of help."
  -> offer_help

=== offer_help ===
Kenji raised an eyebrow. "And why should I trust you?"

* "I have connections and resources that could be useful to you."
  -> offer_resources

* "I'm just trying to make a name for myself. Working with someone like you could be a big step in the right direction."
  -> fair_share

=== offer_resources ===
"I see," Kenji said, his eyes narrowing. "And what's in it for you?"

* "A fair share of the profits, of course."
  -> fair_share

* "The chance to work with a powerful businessman like yourself."
  -> work_with_kenji

=== fair_share ===
Kenji considered this for a moment. "I'll think about it."
  -> bided_time

=== work_with_kenji ===
"I like your ambition," Kenji said, a hint of a smile playing at the corner of his lips. "But I need to know more about you before I make any decisions."
  -> bided_time

=== bided_time ===
I bided my time, waiting for the right moment to make my move.
  -> END


