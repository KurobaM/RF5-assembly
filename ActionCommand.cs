using System;
using Il2CppDummyDll;

// Token: 0x02000086 RID: 134
[Token(Token = "0x2000067")]
[Serializable]
public enum ActionCommand
{
	// Token: 0x040001A0 RID: 416
	[Token(Token = "0x4000139")]
	SE,
	// Token: 0x040001A1 RID: 417
	[Token(Token = "0x400013A")]
	Motion,
	// Token: 0x040001A2 RID: 418
	[Token(Token = "0x400013B")]
	Effect,
	// Token: 0x040001A3 RID: 419
	[Token(Token = "0x400013C")]
	End,
	// Token: 0x040001A4 RID: 420
	[Token(Token = "0x400013D")]
	CanNext,
	// Token: 0x040001A5 RID: 421
	[Token(Token = "0x400013E")]
	InputEnd,
	// Token: 0x040001A6 RID: 422
	[Token(Token = "0x400013F")]
	OnCollisionRight,
	// Token: 0x040001A7 RID: 423
	[Token(Token = "0x4000140")]
	OnCollisionLeft,
	// Token: 0x040001A8 RID: 424
	[Token(Token = "0x4000141")]
	SetReleaseNext,
	// Token: 0x040001A9 RID: 425
	[Token(Token = "0x4000142")]
	FarmAction,
	// Token: 0x040001AA RID: 426
	[Token(Token = "0x4000143")]
	SetFarmRange,
	// Token: 0x040001AB RID: 427
	[Token(Token = "0x4000144")]
	ProjectileAction,
	// Token: 0x040001AC RID: 428
	[Token(Token = "0x4000145")]
	SetSpeed,
	// Token: 0x040001AD RID: 429
	[Token(Token = "0x4000146")]
	SetUseGravity,
	// Token: 0x040001AE RID: 430
	[Token(Token = "0x4000147")]
	SetBehavior,
	// Token: 0x040001AF RID: 431
	[Token(Token = "0x4000148")]
	SetCreateTransform,
	// Token: 0x040001B0 RID: 432
	[Token(Token = "0x4000149")]
	SetCreateTransformOffset,
	// Token: 0x040001B1 RID: 433
	[Token(Token = "0x400014A")]
	AddCollision,
	// Token: 0x040001B2 RID: 434
	[Token(Token = "0x400014B")]
	OnCollision,
	// Token: 0x040001B3 RID: 435
	[Token(Token = "0x400014C")]
	SetActiveLookAtTarget,
	// Token: 0x040001B4 RID: 436
	[Token(Token = "0x400014D")]
	SetNextAction,
	// Token: 0x040001B5 RID: 437
	[Token(Token = "0x400014E")]
	EventProjectileAction,
	// Token: 0x040001B6 RID: 438
	[Token(Token = "0x400014F")]
	MonsterUniqueAction,
	// Token: 0x040001B7 RID: 439
	[Token(Token = "0x4000150")]
	AddForce,
	// Token: 0x040001B8 RID: 440
	[Token(Token = "0x4000151")]
	Approach,
	// Token: 0x040001B9 RID: 441
	[Token(Token = "0x4000152")]
	Magic,
	// Token: 0x040001BA RID: 442
	[Token(Token = "0x4000153")]
	OffCollisionRight,
	// Token: 0x040001BB RID: 443
	[Token(Token = "0x4000154")]
	OffCollisionLeft,
	// Token: 0x040001BC RID: 444
	[Token(Token = "0x4000155")]
	OffCollision,
	// Token: 0x040001BD RID: 445
	[Token(Token = "0x4000156")]
	ClearHitList,
	// Token: 0x040001BE RID: 446
	[Token(Token = "0x4000157")]
	PlayToolEffect,
	// Token: 0x040001BF RID: 447
	[Token(Token = "0x4000158")]
	StopToolEffect,
	// Token: 0x040001C0 RID: 448
	[Token(Token = "0x4000159")]
	SetDamageInformation,
	// Token: 0x040001C1 RID: 449
	[Token(Token = "0x400015A")]
	CanMove,
	// Token: 0x040001C2 RID: 450
	[Token(Token = "0x400015B")]
	WaitCompareAnimatorParam,
	// Token: 0x040001C3 RID: 451
	[Token(Token = "0x400015C")]
	InputStart,
	// Token: 0x040001C4 RID: 452
	[Token(Token = "0x400015D")]
	SetBadStatusDamage,
	// Token: 0x040001C5 RID: 453
	[Token(Token = "0x400015E")]
	SetDamageInfoOption,
	// Token: 0x040001C6 RID: 454
	[Token(Token = "0x400015F")]
	RandomAroundTargetProjectileAction,
	// Token: 0x040001C7 RID: 455
	[Token(Token = "0x4000160")]
	SetScaleProjectile,
	// Token: 0x040001C8 RID: 456
	[Token(Token = "0x4000161")]
	SearchEnemy,
	// Token: 0x040001C9 RID: 457
	[Token(Token = "0x4000162")]
	ChangeMoveType,
	// Token: 0x040001CA RID: 458
	[Token(Token = "0x4000163")]
	RandomRange,
	// Token: 0x040001CB RID: 459
	[Token(Token = "0x4000164")]
	SetLoopShot,
	// Token: 0x040001CC RID: 460
	[Token(Token = "0x4000165")]
	SetBulletParent,
	// Token: 0x040001CD RID: 461
	[Token(Token = "0x4000166")]
	SetBulletHold,
	// Token: 0x040001CE RID: 462
	[Token(Token = "0x4000167")]
	ChangeAnimatorSpeed,
	// Token: 0x040001CF RID: 463
	[Token(Token = "0x4000168")]
	ProjectileActionMagic,
	// Token: 0x040001D0 RID: 464
	[Token(Token = "0x4000169")]
	SetEffect,
	// Token: 0x040001D1 RID: 465
	[Token(Token = "0x400016A")]
	Voice,
	// Token: 0x040001D2 RID: 466
	[Token(Token = "0x400016B")]
	Prefab,
	// Token: 0x040001D3 RID: 467
	[Token(Token = "0x400016C")]
	Brush,
	// Token: 0x040001D4 RID: 468
	[Token(Token = "0x400016D")]
	RPSkillActionCommand,
	// Token: 0x040001D5 RID: 469
	[Token(Token = "0x400016E")]
	RpExpSkillActionCommand,
	// Token: 0x040001D6 RID: 470
	[Token(Token = "0x400016F")]
	DamageCheckStart,
	// Token: 0x040001D7 RID: 471
	[Token(Token = "0x4000170")]
	DamageCheckEnd,
	// Token: 0x040001D8 RID: 472
	[Token(Token = "0x4000171")]
	FootSteps,
	// Token: 0x040001D9 RID: 473
	[Token(Token = "0x4000172")]
	HitCheckStart,
	// Token: 0x040001DA RID: 474
	[Token(Token = "0x4000173")]
	HitCheckEnd,
	// Token: 0x040001DB RID: 475
	[Token(Token = "0x4000174")]
	MonsterMotion,
	// Token: 0x040001DC RID: 476
	[Token(Token = "0x4000175")]
	MagicPlay,
	// Token: 0x040001DD RID: 477
	[Token(Token = "0x4000176")]
	MagicEfficacy,
	// Token: 0x040001DE RID: 478
	[Token(Token = "0x4000177")]
	CameraShake,
	// Token: 0x040001DF RID: 479
	[Token(Token = "0x4000178")]
	CallBit,
	// Token: 0x040001E0 RID: 480
	[Token(Token = "0x4000179")]
	Greeting,
	// Token: 0x040001E1 RID: 481
	[Token(Token = "0x400017A")]
	Next,
	// Token: 0x040001E2 RID: 482
	[Token(Token = "0x400017B")]
	NextRandom,
	// Token: 0x040001E3 RID: 483
	[Token(Token = "0x400017C")]
	BulletLoad,
	// Token: 0x040001E4 RID: 484
	[Token(Token = "0x400017D")]
	Score,
	// Token: 0x040001E5 RID: 485
	[Token(Token = "0x400017E")]
	Avoid,
	// Token: 0x040001E6 RID: 486
	[Token(Token = "0x400017F")]
	AvoidAttack,
	// Token: 0x040001E7 RID: 487
	[Token(Token = "0x4000180")]
	Scissors,
	// Token: 0x040001E8 RID: 488
	[Token(Token = "0x4000181")]
	ActionSpeed,
	// Token: 0x040001E9 RID: 489
	[Token(Token = "0x4000182")]
	MagicCanNext,
	// Token: 0x040001EA RID: 490
	[Token(Token = "0x4000183")]
	AtrubuteMagic,
	// Token: 0x040001EB RID: 491
	[Token(Token = "0x4000184")]
	MagicMedi,
	// Token: 0x040001EC RID: 492
	[Token(Token = "0x4000185")]
	TimeScalePlay,
	// Token: 0x040001ED RID: 493
	[Token(Token = "0x4000186")]
	MagicMotion,
	// Token: 0x040001EE RID: 494
	[Token(Token = "0x4000187")]
	MonsterVoice,
	// Token: 0x040001EF RID: 495
	[Token(Token = "0x4000188")]
	MagicAim,
	// Token: 0x040001F0 RID: 496
	[Token(Token = "0x4000189")]
	GrantAttribute,
	// Token: 0x040001F1 RID: 497
	[Token(Token = "0x400018A")]
	JoroVoice,
	// Token: 0x040001F2 RID: 498
	[Token(Token = "0x400018B")]
	SuperArmor,
	// Token: 0x040001F3 RID: 499
	[Token(Token = "0x400018C")]
	Length
}
