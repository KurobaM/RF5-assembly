using System;
using Il2CppDummyDll;

namespace Define
{
	// Token: 0x02001262 RID: 4706
	[Token(Token = "0x2000C31")]
	public enum NpcAnimState
	{
		// Token: 0x04019FF7 RID: 106487
		[Token(Token = "0x4016A3A")]
		None = -1,
		// Token: 0x04019FF8 RID: 106488
		[Token(Token = "0x4016A3B")]
		Idle,
		// Token: 0x04019FF9 RID: 106489
		[Token(Token = "0x4016A3C")]
		TalkStart,
		// Token: 0x04019FFA RID: 106490
		[Token(Token = "0x4016A3D")]
		TalkLoop,
		// Token: 0x04019FFB RID: 106491
		[Token(Token = "0x4016A3E")]
		Blessing,
		// Token: 0x04019FFC RID: 106492
		[Token(Token = "0x4016A3F")]
		Sitting,
		// Token: 0x04019FFD RID: 106493
		[Token(Token = "0x4016A40")]
		SittingLoop,
		// Token: 0x04019FFE RID: 106494
		[Token(Token = "0x4016A41")]
		Sleeping,
		// Token: 0x04019FFF RID: 106495
		[Token(Token = "0x4016A42")]
		SleepingLoop,
		// Token: 0x0401A000 RID: 106496
		[Token(Token = "0x4016A43")]
		Rain,
		// Token: 0x0401A001 RID: 106497
		[Token(Token = "0x4016A44")]
		RainDash,
		// Token: 0x0401A002 RID: 106498
		[Token(Token = "0x4016A45")]
		DoorOpen,
		// Token: 0x0401A003 RID: 106499
		[Token(Token = "0x4016A46")]
		DoorClose,
		// Token: 0x0401A004 RID: 106500
		[Token(Token = "0x4016A47")]
		WaveHands,
		// Token: 0x0401A005 RID: 106501
		[Token(Token = "0x4016A48")]
		SleepingLeft,
		// Token: 0x0401A006 RID: 106502
		[Token(Token = "0x4016A49")]
		SleepingLeftLoop,
		// Token: 0x0401A007 RID: 106503
		[Token(Token = "0x4016A4A")]
		SittingFloor,
		// Token: 0x0401A008 RID: 106504
		[Token(Token = "0x4016A4B")]
		SittingFloorLoop,
		// Token: 0x0401A009 RID: 106505
		[Token(Token = "0x4016A4C")]
		Emotion_Laugh,
		// Token: 0x0401A00A RID: 106506
		[Token(Token = "0x4016A4D")]
		Emotion_LaughLoop,
		// Token: 0x0401A00B RID: 106507
		[Token(Token = "0x4016A4E")]
		Emotion_Shy,
		// Token: 0x0401A00C RID: 106508
		[Token(Token = "0x4016A4F")]
		Emotion_ShyLoop,
		// Token: 0x0401A00D RID: 106509
		[Token(Token = "0x4016A50")]
		Emotion_Surprise,
		// Token: 0x0401A00E RID: 106510
		[Token(Token = "0x4016A51")]
		Emotion_SurpriseLoop,
		// Token: 0x0401A00F RID: 106511
		[Token(Token = "0x4016A52")]
		Emotion_Sad,
		// Token: 0x0401A010 RID: 106512
		[Token(Token = "0x4016A53")]
		Emotion_SadLoop,
		// Token: 0x0401A011 RID: 106513
		[Token(Token = "0x4016A54")]
		Emotion_Badmood,
		// Token: 0x0401A012 RID: 106514
		[Token(Token = "0x4016A55")]
		Emotion_BadmoodLoop,
		// Token: 0x0401A013 RID: 106515
		[Token(Token = "0x4016A56")]
		Emotion_Getangry,
		// Token: 0x0401A014 RID: 106516
		[Token(Token = "0x4016A57")]
		Emotion_GetangryLoop,
		// Token: 0x0401A015 RID: 106517
		[Token(Token = "0x4016A58")]
		Emotion_Troubled,
		// Token: 0x0401A016 RID: 106518
		[Token(Token = "0x4016A59")]
		Emotion_TroubledLoop,
		// Token: 0x0401A017 RID: 106519
		[Token(Token = "0x4016A5A")]
		Emotion_Think,
		// Token: 0x0401A018 RID: 106520
		[Token(Token = "0x4016A5B")]
		Emotion_ThinkLoop,
		// Token: 0x0401A019 RID: 106521
		[Token(Token = "0x4016A5C")]
		Emotion_Scared,
		// Token: 0x0401A01A RID: 106522
		[Token(Token = "0x4016A5D")]
		Emotion_ScaredLoop,
		// Token: 0x0401A01B RID: 106523
		[Token(Token = "0x4016A5E")]
		Emotion_Flash,
		// Token: 0x0401A01C RID: 106524
		[Token(Token = "0x4016A5F")]
		Emotion_FlashLoop,
		// Token: 0x0401A01D RID: 106525
		[Token(Token = "0x4016A60")]
		Emotion_Yawn,
		// Token: 0x0401A01E RID: 106526
		[Token(Token = "0x4016A61")]
		Emotion_YawnLoop,
		// Token: 0x0401A01F RID: 106527
		[Token(Token = "0x4016A62")]
		Dead,
		// Token: 0x0401A020 RID: 106528
		[Token(Token = "0x4016A63")]
		Applause,
		// Token: 0x0401A021 RID: 106529
		[Token(Token = "0x4016A64")]
		ApplauseLoop,
		// Token: 0x0401A022 RID: 106530
		[Token(Token = "0x4016A65")]
		Eat_Start = 50,
		// Token: 0x0401A023 RID: 106531
		[Token(Token = "0x4016A66")]
		Eat_Loop,
		// Token: 0x0401A024 RID: 106532
		[Token(Token = "0x4016A67")]
		Eat_End,
		// Token: 0x0401A025 RID: 106533
		[Token(Token = "0x4016A68")]
		Burikko = 55,
		// Token: 0x0401A026 RID: 106534
		[Token(Token = "0x4016A69")]
		Eat_Spoon_Start,
		// Token: 0x0401A027 RID: 106535
		[Token(Token = "0x4016A6A")]
		Eat_Spoon_Loop,
		// Token: 0x0401A028 RID: 106536
		[Token(Token = "0x4016A6B")]
		Eat_Spoon_End,
		// Token: 0x0401A029 RID: 106537
		[Token(Token = "0x4016A6C")]
		Sit_Read_Book_Start,
		// Token: 0x0401A02A RID: 106538
		[Token(Token = "0x4016A6D")]
		Sit_Read_Book_Loop,
		// Token: 0x0401A02B RID: 106539
		[Token(Token = "0x4016A6E")]
		Sit_Read_Book_End,
		// Token: 0x0401A02C RID: 106540
		[Token(Token = "0x4016A6F")]
		Sit_Write_Start,
		// Token: 0x0401A02D RID: 106541
		[Token(Token = "0x4016A70")]
		Sit_Write_Loop,
		// Token: 0x0401A02E RID: 106542
		[Token(Token = "0x4016A71")]
		Sit_Write_End,
		// Token: 0x0401A02F RID: 106543
		[Token(Token = "0x4016A72")]
		Sit_Talk_Start,
		// Token: 0x0401A030 RID: 106544
		[Token(Token = "0x4016A73")]
		Sit_Talk_Loop,
		// Token: 0x0401A031 RID: 106545
		[Token(Token = "0x4016A74")]
		Sit_Talk_End,
		// Token: 0x0401A032 RID: 106546
		[Token(Token = "0x4016A75")]
		Sit_Sleep_Start = 69,
		// Token: 0x0401A033 RID: 106547
		[Token(Token = "0x4016A76")]
		Sit_Sleep_Loop,
		// Token: 0x0401A034 RID: 106548
		[Token(Token = "0x4016A77")]
		Sit_Sleep_End,
		// Token: 0x0401A035 RID: 106549
		[Token(Token = "0x4016A78")]
		Sit_Puzzle_Start,
		// Token: 0x0401A036 RID: 106550
		[Token(Token = "0x4016A79")]
		Sit_Puzzle_Loop,
		// Token: 0x0401A037 RID: 106551
		[Token(Token = "0x4016A7A")]
		Sit_Puzzle_End,
		// Token: 0x0401A038 RID: 106552
		[Token(Token = "0x4016A7B")]
		Sit_Sewing_Start,
		// Token: 0x0401A039 RID: 106553
		[Token(Token = "0x4016A7C")]
		Sit_Sewing_Loop,
		// Token: 0x0401A03A RID: 106554
		[Token(Token = "0x4016A7D")]
		Sit_Sewing_End,
		// Token: 0x0401A03B RID: 106555
		[Token(Token = "0x4016A7E")]
		Glasses_Wipe_Start,
		// Token: 0x0401A03C RID: 106556
		[Token(Token = "0x4016A7F")]
		Glasses_Wipe_Loop,
		// Token: 0x0401A03D RID: 106557
		[Token(Token = "0x4016A80")]
		Glasses_Wipe_End,
		// Token: 0x0401A03E RID: 106558
		[Token(Token = "0x4016A81")]
		Sit_Memo_Start,
		// Token: 0x0401A03F RID: 106559
		[Token(Token = "0x4016A82")]
		Sit_Memo_Loop,
		// Token: 0x0401A040 RID: 106560
		[Token(Token = "0x4016A83")]
		Sit_Memo_End,
		// Token: 0x0401A041 RID: 106561
		[Token(Token = "0x4016A84")]
		Sit_Card_Start,
		// Token: 0x0401A042 RID: 106562
		[Token(Token = "0x4016A85")]
		Sit_Card_Loop,
		// Token: 0x0401A043 RID: 106563
		[Token(Token = "0x4016A86")]
		Sit_Card_End,
		// Token: 0x0401A044 RID: 106564
		[Token(Token = "0x4016A87")]
		Sit_Card2_Start,
		// Token: 0x0401A045 RID: 106565
		[Token(Token = "0x4016A88")]
		Sit_Card2_Loop,
		// Token: 0x0401A046 RID: 106566
		[Token(Token = "0x4016A89")]
		Sit_Card2_End,
		// Token: 0x0401A047 RID: 106567
		[Token(Token = "0x4016A8A")]
		Sit_Polishing_Start,
		// Token: 0x0401A048 RID: 106568
		[Token(Token = "0x4016A8B")]
		Sit_Polishing_Loop,
		// Token: 0x0401A049 RID: 106569
		[Token(Token = "0x4016A8C")]
		Sit_Polishing_End,
		// Token: 0x0401A04A RID: 106570
		[Token(Token = "0x4016A8D")]
		Sit_Observation_Start,
		// Token: 0x0401A04B RID: 106571
		[Token(Token = "0x4016A8E")]
		Sit_Observation_Loop,
		// Token: 0x0401A04C RID: 106572
		[Token(Token = "0x4016A8F")]
		Sit_Observation_End,
		// Token: 0x0401A04D RID: 106573
		[Token(Token = "0x4016A90")]
		Stretch,
		// Token: 0x0401A04E RID: 106574
		[Token(Token = "0x4016A91")]
		Look_Start,
		// Token: 0x0401A04F RID: 106575
		[Token(Token = "0x4016A92")]
		Look_Loop,
		// Token: 0x0401A050 RID: 106576
		[Token(Token = "0x4016A93")]
		Look_End,
		// Token: 0x0401A051 RID: 106577
		[Token(Token = "0x4016A94")]
		Rotate90,
		// Token: 0x0401A052 RID: 106578
		[Token(Token = "0x4016A95")]
		Rotate180,
		// Token: 0x0401A053 RID: 106579
		[Token(Token = "0x4016A96")]
		Rotate135 = 199,
		// Token: 0x0401A054 RID: 106580
		[Token(Token = "0x4016A97")]
		Item_Close = 102,
		// Token: 0x0401A055 RID: 106581
		[Token(Token = "0x4016A98")]
		Read_Start,
		// Token: 0x0401A056 RID: 106582
		[Token(Token = "0x4016A99")]
		Read_Loop,
		// Token: 0x0401A057 RID: 106583
		[Token(Token = "0x4016A9A")]
		Read_End,
		// Token: 0x0401A058 RID: 106584
		[Token(Token = "0x4016A9B")]
		Memo_Start,
		// Token: 0x0401A059 RID: 106585
		[Token(Token = "0x4016A9C")]
		Memo_Loop,
		// Token: 0x0401A05A RID: 106586
		[Token(Token = "0x4016A9D")]
		Memo_End,
		// Token: 0x0401A05B RID: 106587
		[Token(Token = "0x4016A9E")]
		Orderly_Start,
		// Token: 0x0401A05C RID: 106588
		[Token(Token = "0x4016A9F")]
		Orderly_Loop,
		// Token: 0x0401A05D RID: 106589
		[Token(Token = "0x4016AA0")]
		Orderly_End,
		// Token: 0x0401A05E RID: 106590
		[Token(Token = "0x4016AA1")]
		bow,
		// Token: 0x0401A05F RID: 106591
		[Token(Token = "0x4016AA2")]
		Hug_Baby,
		// Token: 0x0401A060 RID: 106592
		[Token(Token = "0x4016AA3")]
		Fishing_Stand,
		// Token: 0x0401A061 RID: 106593
		[Token(Token = "0x4016AA4")]
		Fishing_throw,
		// Token: 0x0401A062 RID: 106594
		[Token(Token = "0x4016AA5")]
		Fishing_Pull,
		// Token: 0x0401A063 RID: 106595
		[Token(Token = "0x4016AA6")]
		Fishing_Waiting,
		// Token: 0x0401A064 RID: 106596
		[Token(Token = "0x4016AA7")]
		Fishing_Battle,
		// Token: 0x0401A065 RID: 106597
		[Token(Token = "0x4016AA8")]
		Fishing_Win,
		// Token: 0x0401A066 RID: 106598
		[Token(Token = "0x4016AA9")]
		Rag_Start,
		// Token: 0x0401A067 RID: 106599
		[Token(Token = "0x4016AAA")]
		Rag_Loop,
		// Token: 0x0401A068 RID: 106600
		[Token(Token = "0x4016AAB")]
		Rag_End,
		// Token: 0x0401A069 RID: 106601
		[Token(Token = "0x4016AAC")]
		Bird_Start,
		// Token: 0x0401A06A RID: 106602
		[Token(Token = "0x4016AAD")]
		Bird_Loop,
		// Token: 0x0401A06B RID: 106603
		[Token(Token = "0x4016AAE")]
		Bird_End,
		// Token: 0x0401A06C RID: 106604
		[Token(Token = "0x4016AAF")]
		Flower_Fortune_Start,
		// Token: 0x0401A06D RID: 106605
		[Token(Token = "0x4016AB0")]
		Flower_Fortune_Loop,
		// Token: 0x0401A06E RID: 106606
		[Token(Token = "0x4016AB1")]
		Flower_Fortune_End,
		// Token: 0x0401A06F RID: 106607
		[Token(Token = "0x4016AB2")]
		Watering_Start,
		// Token: 0x0401A070 RID: 106608
		[Token(Token = "0x4016AB3")]
		Watering_Loop,
		// Token: 0x0401A071 RID: 106609
		[Token(Token = "0x4016AB4")]
		Watering_End,
		// Token: 0x0401A072 RID: 106610
		[Token(Token = "0x4016AB5")]
		Sit_SwordCare_Start,
		// Token: 0x0401A073 RID: 106611
		[Token(Token = "0x4016AB6")]
		Sit_SwordCare_Loop,
		// Token: 0x0401A074 RID: 106612
		[Token(Token = "0x4016AB7")]
		Sit_SwordCare_End,
		// Token: 0x0401A075 RID: 106613
		[Token(Token = "0x4016AB8")]
		Sharpening_Start,
		// Token: 0x0401A076 RID: 106614
		[Token(Token = "0x4016AB9")]
		Sharpening_Loop,
		// Token: 0x0401A077 RID: 106615
		[Token(Token = "0x4016ABA")]
		Sharpening_End,
		// Token: 0x0401A078 RID: 106616
		[Token(Token = "0x4016ABB")]
		Hammer_Start,
		// Token: 0x0401A079 RID: 106617
		[Token(Token = "0x4016ABC")]
		Hammer_Loop,
		// Token: 0x0401A07A RID: 106618
		[Token(Token = "0x4016ABD")]
		Hammer_End,
		// Token: 0x0401A07B RID: 106619
		[Token(Token = "0x4016ABE")]
		Crouch_Observe_Start,
		// Token: 0x0401A07C RID: 106620
		[Token(Token = "0x4016ABF")]
		Crouch_Observe_Loop,
		// Token: 0x0401A07D RID: 106621
		[Token(Token = "0x4016AC0")]
		Crouch_Observe_End,
		// Token: 0x0401A07E RID: 106622
		[Token(Token = "0x4016AC1")]
		Brush_Start,
		// Token: 0x0401A07F RID: 106623
		[Token(Token = "0x4016AC2")]
		Brush_Loop,
		// Token: 0x0401A080 RID: 106624
		[Token(Token = "0x4016AC3")]
		Brush_End,
		// Token: 0x0401A081 RID: 106625
		[Token(Token = "0x4016AC4")]
		Referee_Start,
		// Token: 0x0401A082 RID: 106626
		[Token(Token = "0x4016AC5")]
		Referee_Loop,
		// Token: 0x0401A083 RID: 106627
		[Token(Token = "0x4016AC6")]
		Referee_End,
		// Token: 0x0401A084 RID: 106628
		[Token(Token = "0x4016AC7")]
		Saw_Start,
		// Token: 0x0401A085 RID: 106629
		[Token(Token = "0x4016AC8")]
		Saw_Loop,
		// Token: 0x0401A086 RID: 106630
		[Token(Token = "0x4016AC9")]
		Saw_End,
		// Token: 0x0401A087 RID: 106631
		[Token(Token = "0x4016ACA")]
		Trick_Start,
		// Token: 0x0401A088 RID: 106632
		[Token(Token = "0x4016ACB")]
		Trick_Loop,
		// Token: 0x0401A089 RID: 106633
		[Token(Token = "0x4016ACC")]
		Trick_End,
		// Token: 0x0401A08A RID: 106634
		[Token(Token = "0x4016ACD")]
		Sing_Start,
		// Token: 0x0401A08B RID: 106635
		[Token(Token = "0x4016ACE")]
		Sing_Loop,
		// Token: 0x0401A08C RID: 106636
		[Token(Token = "0x4016ACF")]
		Sing_End,
		// Token: 0x0401A08D RID: 106637
		[Token(Token = "0x4016AD0")]
		Observation_Start,
		// Token: 0x0401A08E RID: 106638
		[Token(Token = "0x4016AD1")]
		Observation_Loop,
		// Token: 0x0401A08F RID: 106639
		[Token(Token = "0x4016AD2")]
		Observation_End,
		// Token: 0x0401A090 RID: 106640
		[Token(Token = "0x4016AD3")]
		Look_Palmo_Start,
		// Token: 0x0401A091 RID: 106641
		[Token(Token = "0x4016AD4")]
		Look_Palmo_Loop,
		// Token: 0x0401A092 RID: 106642
		[Token(Token = "0x4016AD5")]
		Look_Palmo_End,
		// Token: 0x0401A093 RID: 106643
		[Token(Token = "0x4016AD6")]
		Look_Karte_Start,
		// Token: 0x0401A094 RID: 106644
		[Token(Token = "0x4016AD7")]
		Look_Karte_Loop,
		// Token: 0x0401A095 RID: 106645
		[Token(Token = "0x4016AD8")]
		Look_Karte_End,
		// Token: 0x0401A096 RID: 106646
		[Token(Token = "0x4016AD9")]
		Mixing_Start,
		// Token: 0x0401A097 RID: 106647
		[Token(Token = "0x4016ADA")]
		Mixing_Loop,
		// Token: 0x0401A098 RID: 106648
		[Token(Token = "0x4016ADB")]
		Mixing_End,
		// Token: 0x0401A099 RID: 106649
		[Token(Token = "0x4016ADC")]
		Look_Crouching_Start,
		// Token: 0x0401A09A RID: 106650
		[Token(Token = "0x4016ADD")]
		Look_Crouching_Loop,
		// Token: 0x0401A09B RID: 106651
		[Token(Token = "0x4016ADE")]
		Look_Crouching_End,
		// Token: 0x0401A09C RID: 106652
		[Token(Token = "0x4016ADF")]
		Write_Ground_Start,
		// Token: 0x0401A09D RID: 106653
		[Token(Token = "0x4016AE0")]
		Write_Ground_Loop,
		// Token: 0x0401A09E RID: 106654
		[Token(Token = "0x4016AE1")]
		Write_Ground_End,
		// Token: 0x0401A09F RID: 106655
		[Token(Token = "0x4016AE2")]
		Bakery_Work_Start,
		// Token: 0x0401A0A0 RID: 106656
		[Token(Token = "0x4016AE3")]
		Bakery_Work_Loop,
		// Token: 0x0401A0A1 RID: 106657
		[Token(Token = "0x4016AE4")]
		Bakery_Work_End,
		// Token: 0x0401A0A2 RID: 106658
		[Token(Token = "0x4016AE5")]
		Cooking_Knife_Start,
		// Token: 0x0401A0A3 RID: 106659
		[Token(Token = "0x4016AE6")]
		Cooking_Knife_Loop,
		// Token: 0x0401A0A4 RID: 106660
		[Token(Token = "0x4016AE7")]
		Cooking_Knife_End,
		// Token: 0x0401A0A5 RID: 106661
		[Token(Token = "0x4016AE8")]
		Training,
		// Token: 0x0401A0A6 RID: 106662
		[Token(Token = "0x4016AE9")]
		Item_Belly,
		// Token: 0x0401A0A7 RID: 106663
		[Token(Token = "0x4016AEA")]
		Item_Head,
		// Token: 0x0401A0A8 RID: 106664
		[Token(Token = "0x4016AEB")]
		Knocking_Cleaning_Start,
		// Token: 0x0401A0A9 RID: 106665
		[Token(Token = "0x4016AEC")]
		Knocking_Cleaning_Loop,
		// Token: 0x0401A0AA RID: 106666
		[Token(Token = "0x4016AED")]
		Knocking_Cleaning_End,
		// Token: 0x0401A0AB RID: 106667
		[Token(Token = "0x4016AEE")]
		Collapse_Start,
		// Token: 0x0401A0AC RID: 106668
		[Token(Token = "0x4016AEF")]
		Collapse_Loop,
		// Token: 0x0401A0AD RID: 106669
		[Token(Token = "0x4016AF0")]
		SitStretch,
		// Token: 0x0401A0AE RID: 106670
		[Token(Token = "0x4016AF1")]
		Battle_Hammer_Wait,
		// Token: 0x0401A0AF RID: 106671
		[Token(Token = "0x4016AF2")]
		Battle_Hammer_Attack,
		// Token: 0x0401A0B0 RID: 106672
		[Token(Token = "0x4016AF3")]
		Item_Belly_Put,
		// Token: 0x0401A0B1 RID: 106673
		[Token(Token = "0x4016AF4")]
		Item_Belly_Lift,
		// Token: 0x0401A0B2 RID: 106674
		[Token(Token = "0x4016AF5")]
		Emotion_Rejoice,
		// Token: 0x0401A0B3 RID: 106675
		[Token(Token = "0x4016AF6")]
		Emotion_Rejoice_Loop,
		// Token: 0x0401A0B4 RID: 106676
		[Token(Token = "0x4016AF7")]
		Sp_Wait,
		// Token: 0x0401A0B5 RID: 106677
		[Token(Token = "0x4016AF8")]
		ShortPlay_Walk = 201,
		// Token: 0x0401A0B6 RID: 106678
		[Token(Token = "0x4016AF9")]
		ShortPlay_Run = 211,
		// Token: 0x0401A0B7 RID: 106679
		[Token(Token = "0x4016AFA")]
		Child_Talk_Start = 230,
		// Token: 0x0401A0B8 RID: 106680
		[Token(Token = "0x4016AFB")]
		Child_Talk_Loop,
		// Token: 0x0401A0B9 RID: 106681
		[Token(Token = "0x4016AFC")]
		Child_Talk_End,
		// Token: 0x0401A0BA RID: 106682
		[Token(Token = "0x4016AFD")]
		Battle_Wand_Wait,
		// Token: 0x0401A0BB RID: 106683
		[Token(Token = "0x4016AFE")]
		Battle_Wand_Attack,
		// Token: 0x0401A0BC RID: 106684
		[Token(Token = "0x4016AFF")]
		Male_wait_1,
		// Token: 0x0401A0BD RID: 106685
		[Token(Token = "0x4016B00")]
		Male_wait_2,
		// Token: 0x0401A0BE RID: 106686
		[Token(Token = "0x4016B01")]
		Male_wait_3,
		// Token: 0x0401A0BF RID: 106687
		[Token(Token = "0x4016B02")]
		Male_wait_4,
		// Token: 0x0401A0C0 RID: 106688
		[Token(Token = "0x4016B03")]
		Male_wait_5,
		// Token: 0x0401A0C1 RID: 106689
		[Token(Token = "0x4016B04")]
		Male_wait_5_Loop,
		// Token: 0x0401A0C2 RID: 106690
		[Token(Token = "0x4016B05")]
		Male_wait_6,
		// Token: 0x0401A0C3 RID: 106691
		[Token(Token = "0x4016B06")]
		Male_wait_6_Loop,
		// Token: 0x0401A0C4 RID: 106692
		[Token(Token = "0x4016B07")]
		Male_wait_7,
		// Token: 0x0401A0C5 RID: 106693
		[Token(Token = "0x4016B08")]
		Male_wait_7_Loop,
		// Token: 0x0401A0C6 RID: 106694
		[Token(Token = "0x4016B09")]
		Male_wait_8,
		// Token: 0x0401A0C7 RID: 106695
		[Token(Token = "0x4016B0A")]
		Male_wait_8_Loop,
		// Token: 0x0401A0C8 RID: 106696
		[Token(Token = "0x4016B0B")]
		Male_wait_9,
		// Token: 0x0401A0C9 RID: 106697
		[Token(Token = "0x4016B0C")]
		Male_wait_9_Loop,
		// Token: 0x0401A0CA RID: 106698
		[Token(Token = "0x4016B0D")]
		Male_wait_10,
		// Token: 0x0401A0CB RID: 106699
		[Token(Token = "0x4016B0E")]
		Male_wait_10_Loop,
		// Token: 0x0401A0CC RID: 106700
		[Token(Token = "0x4016B0F")]
		Male_wait_11,
		// Token: 0x0401A0CD RID: 106701
		[Token(Token = "0x4016B10")]
		Male_wait_11_Loop,
		// Token: 0x0401A0CE RID: 106702
		[Token(Token = "0x4016B11")]
		Female_wait_1 = 261,
		// Token: 0x0401A0CF RID: 106703
		[Token(Token = "0x4016B12")]
		Female_wait_2,
		// Token: 0x0401A0D0 RID: 106704
		[Token(Token = "0x4016B13")]
		Female_wait_3,
		// Token: 0x0401A0D1 RID: 106705
		[Token(Token = "0x4016B14")]
		Female_wait_4,
		// Token: 0x0401A0D2 RID: 106706
		[Token(Token = "0x4016B15")]
		Female_wait_5,
		// Token: 0x0401A0D3 RID: 106707
		[Token(Token = "0x4016B16")]
		Female_wait_6,
		// Token: 0x0401A0D4 RID: 106708
		[Token(Token = "0x4016B17")]
		Female_wait_6_Loop,
		// Token: 0x0401A0D5 RID: 106709
		[Token(Token = "0x4016B18")]
		Female_wait_7,
		// Token: 0x0401A0D6 RID: 106710
		[Token(Token = "0x4016B19")]
		Female_wait_7_Loop,
		// Token: 0x0401A0D7 RID: 106711
		[Token(Token = "0x4016B1A")]
		Female_wait_8,
		// Token: 0x0401A0D8 RID: 106712
		[Token(Token = "0x4016B1B")]
		Female_wait_8_Loop,
		// Token: 0x0401A0D9 RID: 106713
		[Token(Token = "0x4016B1C")]
		Female_wait_9,
		// Token: 0x0401A0DA RID: 106714
		[Token(Token = "0x4016B1D")]
		Female_wait_9_Loop,
		// Token: 0x0401A0DB RID: 106715
		[Token(Token = "0x4016B1E")]
		Female_wait_10,
		// Token: 0x0401A0DC RID: 106716
		[Token(Token = "0x4016B1F")]
		Female_wait_10_Loop,
		// Token: 0x0401A0DD RID: 106717
		[Token(Token = "0x4016B20")]
		Madness = 280,
		// Token: 0x0401A0DE RID: 106718
		[Token(Token = "0x4016B21")]
		Attack_1,
		// Token: 0x0401A0DF RID: 106719
		[Token(Token = "0x4016B22")]
		Attack_2,
		// Token: 0x0401A0E0 RID: 106720
		[Token(Token = "0x4016B23")]
		Locomotion,
		// Token: 0x0401A0E1 RID: 106721
		[Token(Token = "0x4016B24")]
		Fly,
		// Token: 0x0401A0E2 RID: 106722
		[Token(Token = "0x4016B25")]
		Collapse,
		// Token: 0x0401A0E3 RID: 106723
		[Token(Token = "0x4016B26")]
		Madness_Start,
		// Token: 0x0401A0E4 RID: 106724
		[Token(Token = "0x4016B27")]
		Farmdragon_01_soil_wait01 = 290,
		// Token: 0x0401A0E5 RID: 106725
		[Token(Token = "0x4016B28")]
		Farmdragon_01_soil_wait02,
		// Token: 0x0401A0E6 RID: 106726
		[Token(Token = "0x4016B29")]
		Farmdragon_01_soil_wait03,
		// Token: 0x0401A0E7 RID: 106727
		[Token(Token = "0x4016B2A")]
		Farmdragon_crystal_eat,
		// Token: 0x0401A0E8 RID: 106728
		[Token(Token = "0x4016B2B")]
		RotateSlow90 = 300,
		// Token: 0x0401A0E9 RID: 106729
		[Token(Token = "0x4016B2C")]
		RotateSlow135,
		// Token: 0x0401A0EA RID: 106730
		[Token(Token = "0x4016B2D")]
		RotateSlow180,
		// Token: 0x0401A0EB RID: 106731
		[Token(Token = "0x4016B2E")]
		RotateReverse90,
		// Token: 0x0401A0EC RID: 106732
		[Token(Token = "0x4016B2F")]
		RotateReverse135,
		// Token: 0x0401A0ED RID: 106733
		[Token(Token = "0x4016B30")]
		RotateReverse180,
		// Token: 0x0401A0EE RID: 106734
		[Token(Token = "0x4016B31")]
		ShortPlay_Item_Walk_Belly = 501,
		// Token: 0x0401A0EF RID: 106735
		[Token(Token = "0x4016B32")]
		ShortPlay_Item_Run_Belly,
		// Token: 0x0401A0F0 RID: 106736
		[Token(Token = "0x4016B33")]
		Collapse_Start_Prone,
		// Token: 0x0401A0F1 RID: 106737
		[Token(Token = "0x4016B34")]
		Collapse_Loop_Prone,
		// Token: 0x0401A0F2 RID: 106738
		[Token(Token = "0x4016B35")]
		Emotion_Shock,
		// Token: 0x0401A0F3 RID: 106739
		[Token(Token = "0x4016B36")]
		Emotion_Shock_Loop,
		// Token: 0x0401A0F4 RID: 106740
		[Token(Token = "0x4016B37")]
		Maiking_End,
		// Token: 0x0401A0F5 RID: 106741
		[Token(Token = "0x4016B38")]
		ForceIdle = 999
	}
}
