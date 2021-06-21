using System;
using Define;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;

// Token: 0x02000344 RID: 836
[Token(Token = "0x2000273")]
[Serializable]
public class BulletData
{
	// Token: 0x06001648 RID: 5704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013BA")]
	[Address(RVA = "0x2193DD0", Offset = "0x2193ED1", VA = "0x2193DD0")]
	public BulletData()
	{
	}

	// Token: 0x04000DC0 RID: 3520
	[Token(Token = "0x4000AA1")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public BulletAttach Attach;

	// Token: 0x04000DC1 RID: 3521
	[Token(Token = "0x4000AA2")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public BulletMotorType Type;

	// Token: 0x04000DC2 RID: 3522
	[Token(Token = "0x4000AA3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public bool Interception;

	// Token: 0x04000DC3 RID: 3523
	[Token(Token = "0x4000AA4")]
	[FieldOffset(Offset = "0x19")]
	[SerializeField]
	public bool AdjustAngle;

	// Token: 0x04000DC4 RID: 3524
	[Token(Token = "0x4000AA5")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float InitSpeed;

	// Token: 0x04000DC5 RID: 3525
	[Token(Token = "0x4000AA6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float Acceleration;

	// Token: 0x04000DC6 RID: 3526
	[Token(Token = "0x4000AA7")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public float MaxSpeed;

	// Token: 0x04000DC7 RID: 3527
	[Token(Token = "0x4000AA8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float MinSpeed;

	// Token: 0x04000DC8 RID: 3528
	[Token(Token = "0x4000AA9")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public float BaseScale;

	// Token: 0x04000DC9 RID: 3529
	[Token(Token = "0x4000AAA")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public float RootOffsetX;

	// Token: 0x04000DCA RID: 3530
	[Token(Token = "0x4000AAB")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public float RootOffsetY;

	// Token: 0x04000DCB RID: 3531
	[Token(Token = "0x4000AAC")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public float RootOffsetZ;

	// Token: 0x04000DCC RID: 3532
	[Token(Token = "0x4000AAD")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public float RootRotateX;

	// Token: 0x04000DCD RID: 3533
	[Token(Token = "0x4000AAE")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public float RootRotateY;

	// Token: 0x04000DCE RID: 3534
	[Token(Token = "0x4000AAF")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	public float RootRotateZ;

	// Token: 0x04000DCF RID: 3535
	[Token(Token = "0x4000AB0")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public float RootScaleX;

	// Token: 0x04000DD0 RID: 3536
	[Token(Token = "0x4000AB1")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public float RootScaleY;

	// Token: 0x04000DD1 RID: 3537
	[Token(Token = "0x4000AB2")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public float RootScaleZ;

	// Token: 0x04000DD2 RID: 3538
	[Token(Token = "0x4000AB3")]
	[FieldOffset(Offset = "0x54")]
	public int MaxHitCount;

	// Token: 0x04000DD3 RID: 3539
	[Token(Token = "0x4000AB4")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public BulletHitCharaEvent HitChara_Event;

	// Token: 0x04000DD4 RID: 3540
	[Token(Token = "0x4000AB5")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	public BulletHitAlliance HitChara_Alliance;

	// Token: 0x04000DD5 RID: 3541
	[Token(Token = "0x4000AB6")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public int HitChara_MaxHitCount;

	// Token: 0x04000DD6 RID: 3542
	[Token(Token = "0x4000AB7")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	public float HitChara_HitInterval;

	// Token: 0x04000DD7 RID: 3543
	[Token(Token = "0x4000AB8")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public BulletHitObstacleEvent HitObstacle_Event;

	// Token: 0x04000DD8 RID: 3544
	[Token(Token = "0x4000AB9")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	public int HitObstacle_MaxHitCount;

	// Token: 0x04000DD9 RID: 3545
	[Token(Token = "0x4000ABA")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public float HitObstacle_HitInterval;

	// Token: 0x04000DDA RID: 3546
	[Token(Token = "0x4000ABB")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	public float LifeTime;

	// Token: 0x04000DDB RID: 3547
	[Token(Token = "0x4000ABC")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public float LifeDistance;

	// Token: 0x04000DDC RID: 3548
	[Token(Token = "0x4000ABD")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	public float Homing_StartTime;

	// Token: 0x04000DDD RID: 3549
	[Token(Token = "0x4000ABE")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	public float Homing_Range;

	// Token: 0x04000DDE RID: 3550
	[Token(Token = "0x4000ABF")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	public float Homing_Inductive;

	// Token: 0x04000DDF RID: 3551
	[Token(Token = "0x4000AC0")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	public float Spin_SpeedX;

	// Token: 0x04000DE0 RID: 3552
	[Token(Token = "0x4000AC1")]
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	public float Spin_SpeedY;

	// Token: 0x04000DE1 RID: 3553
	[Token(Token = "0x4000AC2")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	public float Spin_SpeedZ;

	// Token: 0x04000DE2 RID: 3554
	[Token(Token = "0x4000AC3")]
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	public float Curve_SpeedX;

	// Token: 0x04000DE3 RID: 3555
	[Token(Token = "0x4000AC4")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	public float Curve_SpeedY;

	// Token: 0x04000DE4 RID: 3556
	[Token(Token = "0x4000AC5")]
	[FieldOffset(Offset = "0x9C")]
	[SerializeField]
	public float Curve_SpeedZ;

	// Token: 0x04000DE5 RID: 3557
	[Token(Token = "0x4000AC6")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	public float Curve_Duration;

	// Token: 0x04000DE6 RID: 3558
	[Token(Token = "0x4000AC7")]
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	public float Swing_SizeX;

	// Token: 0x04000DE7 RID: 3559
	[Token(Token = "0x4000AC8")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	public float Swing_SizeY;

	// Token: 0x04000DE8 RID: 3560
	[Token(Token = "0x4000AC9")]
	[FieldOffset(Offset = "0xAC")]
	[SerializeField]
	public float Swing_SizeZ;

	// Token: 0x04000DE9 RID: 3561
	[Token(Token = "0x4000ACA")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	public float Swing_DurationX;

	// Token: 0x04000DEA RID: 3562
	[Token(Token = "0x4000ACB")]
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	public float Swing_DurationY;

	// Token: 0x04000DEB RID: 3563
	[Token(Token = "0x4000ACC")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	public float Swing_DurationZ;

	// Token: 0x04000DEC RID: 3564
	[Token(Token = "0x4000ACD")]
	[FieldOffset(Offset = "0xBC")]
	[SerializeField]
	public float Rotate_StartTime;

	// Token: 0x04000DED RID: 3565
	[Token(Token = "0x4000ACE")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	public float Rotate_EndTime;

	// Token: 0x04000DEE RID: 3566
	[Token(Token = "0x4000ACF")]
	[FieldOffset(Offset = "0xC4")]
	[SerializeField]
	public float Rotate_AngleX;

	// Token: 0x04000DEF RID: 3567
	[Token(Token = "0x4000AD0")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	public float Rotate_AngleY;

	// Token: 0x04000DF0 RID: 3568
	[Token(Token = "0x4000AD1")]
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	public float Rotate_AngleZ;

	// Token: 0x04000DF1 RID: 3569
	[Token(Token = "0x4000AD2")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	public float AttractForce_Radius;

	// Token: 0x04000DF2 RID: 3570
	[Token(Token = "0x4000AD3")]
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	public float AttractForce_Power;

	// Token: 0x04000DF3 RID: 3571
	[Token(Token = "0x4000AD4")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	public TargetAlliance AttractForce_Alliance;

	// Token: 0x04000DF4 RID: 3572
	[Token(Token = "0x4000AD5")]
	[FieldOffset(Offset = "0xDC")]
	[SerializeField]
	public float ChangeSpeed_StartTime;

	// Token: 0x04000DF5 RID: 3573
	[Token(Token = "0x4000AD6")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	public float ChangeSpeed_Speed;

	// Token: 0x04000DF6 RID: 3574
	[Token(Token = "0x4000AD7")]
	[FieldOffset(Offset = "0xE4")]
	[SerializeField]
	public float ChangeAccele_StartTime;

	// Token: 0x04000DF7 RID: 3575
	[Token(Token = "0x4000AD8")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	public float ChangeAccele_Accele;

	// Token: 0x04000DF8 RID: 3576
	[Token(Token = "0x4000AD9")]
	[FieldOffset(Offset = "0xEC")]
	[SerializeField]
	public float ChangeScale_StartTime;

	// Token: 0x04000DF9 RID: 3577
	[Token(Token = "0x4000ADA")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	public float ChangeScale_EndTime;

	// Token: 0x04000DFA RID: 3578
	[Token(Token = "0x4000ADB")]
	[FieldOffset(Offset = "0xF4")]
	[SerializeField]
	public float ChangeScale_ScaleX;

	// Token: 0x04000DFB RID: 3579
	[Token(Token = "0x4000ADC")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	public float ChangeScale_ScaleY;

	// Token: 0x04000DFC RID: 3580
	[Token(Token = "0x4000ADD")]
	[FieldOffset(Offset = "0xFC")]
	[SerializeField]
	public float ChangeScale_ScaleZ;

	// Token: 0x04000DFD RID: 3581
	[Token(Token = "0x4000ADE")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	public float Grounder_Height;

	// Token: 0x04000DFE RID: 3582
	[Token(Token = "0x4000ADF")]
	[FieldOffset(Offset = "0x104")]
	[SerializeField]
	public EffectID Grounder_EffectID;

	// Token: 0x04000DFF RID: 3583
	[Token(Token = "0x4000AE0")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	public float Grounder_Interval;

	// Token: 0x04000E00 RID: 3584
	[Token(Token = "0x4000AE1")]
	[FieldOffset(Offset = "0x10C")]
	[SerializeField]
	public BulletExplosionType Explosion_Type;

	// Token: 0x04000E01 RID: 3585
	[Token(Token = "0x4000AE2")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	public float Explosion_Radius;

	// Token: 0x04000E02 RID: 3586
	[Token(Token = "0x4000AE3")]
	[FieldOffset(Offset = "0x114")]
	[SerializeField]
	public EffectID Explosion_EffectID;

	// Token: 0x04000E03 RID: 3587
	[Token(Token = "0x4000AE4")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	public float Explosion_EffectScale;

	// Token: 0x04000E04 RID: 3588
	[Token(Token = "0x4000AE5")]
	[FieldOffset(Offset = "0x11C")]
	[SerializeField]
	public MagicParamID Explosion_ParamID;

	// Token: 0x04000E05 RID: 3589
	[Token(Token = "0x4000AE6")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	public float Laser_Radius;

	// Token: 0x04000E06 RID: 3590
	[Token(Token = "0x4000AE7")]
	[FieldOffset(Offset = "0x124")]
	[SerializeField]
	public float Laser_Length;

	// Token: 0x04000E07 RID: 3591
	[Token(Token = "0x4000AE8")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	public float Laser_Speed;

	// Token: 0x04000E08 RID: 3592
	[Token(Token = "0x4000AE9")]
	[FieldOffset(Offset = "0x12C")]
	[SerializeField]
	public float Search_Radius;

	// Token: 0x04000E09 RID: 3593
	[Token(Token = "0x4000AEA")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	public float Search_Interval;

	// Token: 0x04000E0A RID: 3594
	[Token(Token = "0x4000AEB")]
	[FieldOffset(Offset = "0x134")]
	[SerializeField]
	public TargetAlliance Search_Alliance;

	// Token: 0x04000E0B RID: 3595
	[Token(Token = "0x4000AEC")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	public BulletScriptPlayType Script_PlayType;

	// Token: 0x04000E0C RID: 3596
	[Token(Token = "0x4000AED")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	public string Script_Name;

	// Token: 0x04000E0D RID: 3597
	[Token(Token = "0x4000AEE")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	public Prefab PrefabID;

	// Token: 0x04000E0E RID: 3598
	[Token(Token = "0x4000AEF")]
	[FieldOffset(Offset = "0x14C")]
	[SerializeField]
	public bool EffectLoop;

	// Token: 0x04000E0F RID: 3599
	[Token(Token = "0x4000AF0")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	public MagicParamID ParamID;

	// Token: 0x04000E10 RID: 3600
	[Token(Token = "0x4000AF1")]
	[FieldOffset(Offset = "0x154")]
	[SerializeField]
	public SoundID SoundID;

	// Token: 0x04000E11 RID: 3601
	[Token(Token = "0x4000AF2")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	public EffectID Shot_EffectID;

	// Token: 0x04000E12 RID: 3602
	[Token(Token = "0x4000AF3")]
	[FieldOffset(Offset = "0x15C")]
	[SerializeField]
	public SoundID Shot_SoundID;

	// Token: 0x04000E13 RID: 3603
	[Token(Token = "0x4000AF4")]
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	public SoundID Shot_SoundID2;

	// Token: 0x04000E14 RID: 3604
	[Token(Token = "0x4000AF5")]
	[FieldOffset(Offset = "0x164")]
	[SerializeField]
	public EffectID Dead_EffectID;

	// Token: 0x04000E15 RID: 3605
	[Token(Token = "0x4000AF6")]
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	public SoundID Dead_SoundID;

	// Token: 0x04000E16 RID: 3606
	[Token(Token = "0x4000AF7")]
	[FieldOffset(Offset = "0x16C")]
	[SerializeField]
	public EffectID Hit_EffectID;

	// Token: 0x04000E17 RID: 3607
	[Token(Token = "0x4000AF8")]
	[FieldOffset(Offset = "0x170")]
	[SerializeField]
	public SoundID Hit_SoundID;
}
