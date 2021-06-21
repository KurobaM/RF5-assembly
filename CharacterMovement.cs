using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

// Token: 0x0200021C RID: 540
[Token(Token = "0x20001B7")]
public class CharacterMovement : MonoBehaviour
{
	// Token: 0x06000C0D RID: 3085 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ABB")]
	[Address(RVA = "0x1E8FCF0", Offset = "0x1E8FDF1", VA = "0x1E8FCF0")]
	public void SetMoveParamID(MoveParamID id)
	{
	}

	// Token: 0x17000240 RID: 576
	// (get) Token: 0x06000C0E RID: 3086 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C0F RID: 3087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000223")]
	public CharacterMoveParam MoveParam
	{
		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x1E8FEC0", Offset = "0x1E8FFC1", VA = "0x1E8FEC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B640", Offset = "0x19B741")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x1E8FED0", Offset = "0x1E8FFD1", VA = "0x1E8FED0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B650", Offset = "0x19B751")]
		protected set
		{
		}
	}

	// Token: 0x17000241 RID: 577
	// (get) Token: 0x06000C10 RID: 3088 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C11 RID: 3089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000224")]
	public CharacterMoveSetting MoveSetting
	{
		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x1E8FEE0", Offset = "0x1E8FFE1", VA = "0x1E8FEE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B660", Offset = "0x19B761")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x1E8FEF0", Offset = "0x1E8FFF1", VA = "0x1E8FEF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B670", Offset = "0x19B771")]
		protected set
		{
		}
	}

	// Token: 0x17000242 RID: 578
	// (get) Token: 0x06000C12 RID: 3090 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C13 RID: 3091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000225")]
	public Character Chara
	{
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x1E8FF00", Offset = "0x1E90001", VA = "0x1E8FF00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B680", Offset = "0x19B781")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x1E8FF10", Offset = "0x1E90011", VA = "0x1E8FF10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B690", Offset = "0x19B791")]
		private set
		{
		}
	}

	// Token: 0x17000243 RID: 579
	// (get) Token: 0x06000C14 RID: 3092 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C15 RID: 3093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000226")]
	private NavMeshAgent NavMeshAgent
	{
		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x1E8FF20", Offset = "0x1E90021", VA = "0x1E8FF20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B6A0", Offset = "0x19B7A1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x1E8FF30", Offset = "0x1E90031", VA = "0x1E8FF30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B6B0", Offset = "0x19B7B1")]
		set
		{
		}
	}

	// Token: 0x17000244 RID: 580
	// (get) Token: 0x06000C16 RID: 3094 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C17 RID: 3095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000227")]
	private CharacterController CharacterController
	{
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x1E8FF40", Offset = "0x1E90041", VA = "0x1E8FF40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B6C0", Offset = "0x19B7C1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x1E8FF50", Offset = "0x1E90051", VA = "0x1E8FF50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B6D0", Offset = "0x19B7D1")]
		set
		{
		}
	}

	// Token: 0x17000245 RID: 581
	// (get) Token: 0x06000C18 RID: 3096 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C19 RID: 3097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000228")]
	private Rigidbody Rigidbody
	{
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x1E8FF60", Offset = "0x1E90061", VA = "0x1E8FF60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B6E0", Offset = "0x19B7E1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x1E8FF70", Offset = "0x1E90071", VA = "0x1E8FF70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B6F0", Offset = "0x19B7F1")]
		set
		{
		}
	}

	// Token: 0x17000246 RID: 582
	// (get) Token: 0x06000C1A RID: 3098 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000229")]
	public AnimationCurve LocomotionCurve
	{
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x1E8FF80", Offset = "0x1E90081", VA = "0x1E8FF80")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000247 RID: 583
	// (get) Token: 0x06000C1B RID: 3099 RVA: 0x00005C70 File Offset: 0x00003E70
	// (set) Token: 0x06000C1C RID: 3100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700022A")]
	public bool useGravity
	{
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x1E8FF90", Offset = "0x1E90091", VA = "0x1E8FF90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x1E8FFA0", Offset = "0x1E900A1", VA = "0x1E8FFA0")]
		set
		{
		}
	}

	// Token: 0x17000248 RID: 584
	// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00005C88 File Offset: 0x00003E88
	[Token(Token = "0x1700022B")]
	public bool IsMove
	{
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x1E8FFB0", Offset = "0x1E900B1", VA = "0x1E8FFB0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000249 RID: 585
	// (get) Token: 0x06000C1E RID: 3102 RVA: 0x00005CA0 File Offset: 0x00003EA0
	[Token(Token = "0x1700022C")]
	public bool isGrounded
	{
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x1E8FFD0", Offset = "0x1E900D1", VA = "0x1E8FFD0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700024A RID: 586
	// (get) Token: 0x06000C1F RID: 3103 RVA: 0x00005CB8 File Offset: 0x00003EB8
	// (set) Token: 0x06000C20 RID: 3104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700022D")]
	public bool isValidGround
	{
		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x1E8FFF0", Offset = "0x1E900F1", VA = "0x1E8FFF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B700", Offset = "0x19B801")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x1E90000", Offset = "0x1E90101", VA = "0x1E90000")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B710", Offset = "0x19B811")]
		private set
		{
		}
	}

	// Token: 0x1700024B RID: 587
	// (get) Token: 0x06000C21 RID: 3105 RVA: 0x00005CD0 File Offset: 0x00003ED0
	// (set) Token: 0x06000C22 RID: 3106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700022E")]
	public bool isOnGround
	{
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x1E90010", Offset = "0x1E90111", VA = "0x1E90010")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B720", Offset = "0x19B821")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x1E90020", Offset = "0x1E90121", VA = "0x1E90020")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B730", Offset = "0x19B831")]
		protected set
		{
		}
	}

	// Token: 0x1700024C RID: 588
	// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00005CE8 File Offset: 0x00003EE8
	// (set) Token: 0x06000C24 RID: 3108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700022F")]
	public bool isOnStep
	{
		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x1E90030", Offset = "0x1E90131", VA = "0x1E90030")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B740", Offset = "0x19B841")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x1E90040", Offset = "0x1E90141", VA = "0x1E90040")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B750", Offset = "0x19B851")]
		protected set
		{
		}
	}

	// Token: 0x1700024D RID: 589
	// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00005D00 File Offset: 0x00003F00
	// (set) Token: 0x06000C26 RID: 3110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000230")]
	public bool isOnSlope
	{
		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x1E90050", Offset = "0x1E90151", VA = "0x1E90050")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B760", Offset = "0x19B861")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x1E90060", Offset = "0x1E90161", VA = "0x1E90060")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B770", Offset = "0x19B871")]
		protected set
		{
		}
	}

	// Token: 0x1700024E RID: 590
	// (get) Token: 0x06000C27 RID: 3111 RVA: 0x00005D18 File Offset: 0x00003F18
	// (set) Token: 0x06000C28 RID: 3112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000231")]
	public bool wasOnGround
	{
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x1E90070", Offset = "0x1E90171", VA = "0x1E90070")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B780", Offset = "0x19B881")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x1E90080", Offset = "0x1E90181", VA = "0x1E90080")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B790", Offset = "0x19B891")]
		protected set
		{
		}
	}

	// Token: 0x1700024F RID: 591
	// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00005D30 File Offset: 0x00003F30
	// (set) Token: 0x06000C2A RID: 3114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000232")]
	public bool wasOnStep
	{
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x1E90090", Offset = "0x1E90191", VA = "0x1E90090")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B7A0", Offset = "0x19B8A1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x1E900A0", Offset = "0x1E901A1", VA = "0x1E900A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B7B0", Offset = "0x19B8B1")]
		protected set
		{
		}
	}

	// Token: 0x17000250 RID: 592
	// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00005D48 File Offset: 0x00003F48
	// (set) Token: 0x06000C2C RID: 3116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000233")]
	public bool wasOnSlope
	{
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x1E900B0", Offset = "0x1E901B1", VA = "0x1E900B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B7C0", Offset = "0x19B8C1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x1E900C0", Offset = "0x1E901C1", VA = "0x1E900C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B7D0", Offset = "0x19B8D1")]
		protected set
		{
		}
	}

	// Token: 0x17000251 RID: 593
	// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00005D60 File Offset: 0x00003F60
	// (set) Token: 0x06000C2E RID: 3118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000234")]
	public bool isFalling
	{
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x1E900D0", Offset = "0x1E901D1", VA = "0x1E900D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B7E0", Offset = "0x19B8E1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x1E900E0", Offset = "0x1E901E1", VA = "0x1E900E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B7F0", Offset = "0x19B8F1")]
		protected set
		{
		}
	}

	// Token: 0x17000252 RID: 594
	// (get) Token: 0x06000C2F RID: 3119 RVA: 0x00005D78 File Offset: 0x00003F78
	// (set) Token: 0x06000C30 RID: 3120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000235")]
	public Vector3 GroundNormal
	{
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x1E900F0", Offset = "0x1E901F1", VA = "0x1E900F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B800", Offset = "0x19B901")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x1E90100", Offset = "0x1E90201", VA = "0x1E90100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B810", Offset = "0x19B911")]
		private set
		{
		}
	}

	// Token: 0x17000253 RID: 595
	// (get) Token: 0x06000C31 RID: 3121 RVA: 0x00005D90 File Offset: 0x00003F90
	// (set) Token: 0x06000C32 RID: 3122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000236")]
	public Vector3 MoveDirection
	{
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x1E90110", Offset = "0x1E90211", VA = "0x1E90110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B820", Offset = "0x19B921")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x1E90120", Offset = "0x1E90221", VA = "0x1E90120")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B830", Offset = "0x19B931")]
		set
		{
		}
	}

	// Token: 0x17000254 RID: 596
	// (get) Token: 0x06000C33 RID: 3123 RVA: 0x00005DA8 File Offset: 0x00003FA8
	// (set) Token: 0x06000C34 RID: 3124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000237")]
	public Vector3 RotateDirection
	{
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x1E90130", Offset = "0x1E90231", VA = "0x1E90130")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B840", Offset = "0x19B941")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x1E90140", Offset = "0x1E90241", VA = "0x1E90140")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B850", Offset = "0x19B951")]
		set
		{
		}
	}

	// Token: 0x17000255 RID: 597
	// (get) Token: 0x06000C35 RID: 3125 RVA: 0x00005DC0 File Offset: 0x00003FC0
	// (set) Token: 0x06000C36 RID: 3126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000238")]
	public Vector3 Velocity
	{
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x1E90150", Offset = "0x1E90251", VA = "0x1E90150")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x1E90190", Offset = "0x1E90291", VA = "0x1E90190")]
		set
		{
		}
	}

	// Token: 0x17000256 RID: 598
	// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00005DD8 File Offset: 0x00003FD8
	[Token(Token = "0x17000239")]
	public Vector3 VelocityHorizon
	{
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x1E901D0", Offset = "0x1E902D1", VA = "0x1E901D0")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000257 RID: 599
	// (get) Token: 0x06000C38 RID: 3128 RVA: 0x00005DF0 File Offset: 0x00003FF0
	// (set) Token: 0x06000C39 RID: 3129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700023A")]
	public Vector3 VelocityAtLanding
	{
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x1E902A0", Offset = "0x1E903A1", VA = "0x1E902A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B860", Offset = "0x19B961")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x1E902B0", Offset = "0x1E903B1", VA = "0x1E902B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B870", Offset = "0x19B971")]
		private set
		{
		}
	}

	// Token: 0x17000258 RID: 600
	// (get) Token: 0x06000C3A RID: 3130 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C3B RID: 3131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700023B")]
	public Collider CapsuleCollider
	{
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x1E902C0", Offset = "0x1E903C1", VA = "0x1E902C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B880", Offset = "0x19B981")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x1E902D0", Offset = "0x1E903D1", VA = "0x1E902D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B890", Offset = "0x19B991")]
		set
		{
		}
	}

	// Token: 0x17000259 RID: 601
	// (get) Token: 0x06000C3C RID: 3132 RVA: 0x00005E08 File Offset: 0x00004008
	// (set) Token: 0x06000C3D RID: 3133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700023C")]
	private float capsuleRadius
	{
		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x1E902E0", Offset = "0x1E903E1", VA = "0x1E902E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B8A0", Offset = "0x19B9A1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x1E902F0", Offset = "0x1E903F1", VA = "0x1E902F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B8B0", Offset = "0x19B9B1")]
		set
		{
		}
	}

	// Token: 0x1700025A RID: 602
	// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00005E20 File Offset: 0x00004020
	// (set) Token: 0x06000C3F RID: 3135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700023D")]
	private float capsuleHeight
	{
		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x1E90300", Offset = "0x1E90401", VA = "0x1E90300")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B8C0", Offset = "0x19B9C1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x1E90310", Offset = "0x1E90411", VA = "0x1E90310")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B8D0", Offset = "0x19B9D1")]
		set
		{
		}
	}

	// Token: 0x1700025B RID: 603
	// (get) Token: 0x06000C40 RID: 3136 RVA: 0x00005E38 File Offset: 0x00004038
	// (set) Token: 0x06000C41 RID: 3137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700023E")]
	private Vector3 capsuleCenter
	{
		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x1E90320", Offset = "0x1E90421", VA = "0x1E90320")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B8E0", Offset = "0x19B9E1")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x1E90330", Offset = "0x1E90431", VA = "0x1E90330")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B8F0", Offset = "0x19B9F1")]
		set
		{
		}
	}

	// Token: 0x1700025C RID: 604
	// (get) Token: 0x06000C42 RID: 3138 RVA: 0x00005E50 File Offset: 0x00004050
	// (set) Token: 0x06000C43 RID: 3139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700023F")]
	private float capsuleSkinWidth
	{
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x1E90340", Offset = "0x1E90441", VA = "0x1E90340")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B900", Offset = "0x19BA01")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x1E90350", Offset = "0x1E90451", VA = "0x1E90350")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B910", Offset = "0x19BA11")]
		set
		{
		}
	}

	// Token: 0x1700025D RID: 605
	// (get) Token: 0x06000C44 RID: 3140 RVA: 0x00005E68 File Offset: 0x00004068
	// (set) Token: 0x06000C45 RID: 3141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000240")]
	private float stepOffset
	{
		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x1E90360", Offset = "0x1E90461", VA = "0x1E90360")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B920", Offset = "0x19BA21")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x1E90370", Offset = "0x1E90471", VA = "0x1E90370")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B930", Offset = "0x19BA31")]
		set
		{
		}
	}

	// Token: 0x1700025E RID: 606
	// (get) Token: 0x06000C46 RID: 3142 RVA: 0x00005E80 File Offset: 0x00004080
	// (set) Token: 0x06000C47 RID: 3143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000241")]
	private LayerMask overlapMask
	{
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x1E90380", Offset = "0x1E90481", VA = "0x1E90380")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B940", Offset = "0x19BA41")]
		get
		{
			return default(LayerMask);
		}
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x1E90390", Offset = "0x1E90491", VA = "0x1E90390")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B950", Offset = "0x19BA51")]
		set
		{
		}
	}

	// Token: 0x1700025F RID: 607
	// (get) Token: 0x06000C48 RID: 3144 RVA: 0x00005E98 File Offset: 0x00004098
	// (set) Token: 0x06000C49 RID: 3145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000242")]
	public bool enableEnemyCollision
	{
		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x1E903A0", Offset = "0x1E904A1", VA = "0x1E903A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B960", Offset = "0x19BA61")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x1E903B0", Offset = "0x1E904B1", VA = "0x1E903B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B970", Offset = "0x19BA71")]
		set
		{
		}
	}

	// Token: 0x17000260 RID: 608
	// (get) Token: 0x06000C4A RID: 3146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000243")]
	public static CharacterMoveSetting CharacterMoveSetting
	{
		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x1E903C0", Offset = "0x1E904C1", VA = "0x1E903C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000261 RID: 609
	// (get) Token: 0x06000C4B RID: 3147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000244")]
	public static CharacterMoveParamArray CharacterMoveParamArray
	{
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x1E8FE10", Offset = "0x1E8FF11", VA = "0x1E8FE10")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000C4C RID: 3148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFA")]
	[Address(RVA = "0x1E90470", Offset = "0x1E90571", VA = "0x1E90470")]
	public void Init(CharacterController controller)
	{
	}

	// Token: 0x06000C4D RID: 3149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFB")]
	[Address(RVA = "0x1E905C0", Offset = "0x1E906C1", VA = "0x1E905C0")]
	public void Init(Collider collider, Rigidbody rigidbody)
	{
	}

	// Token: 0x06000C4E RID: 3150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFC")]
	[Address(RVA = "0x1E90740", Offset = "0x1E90841", VA = "0x1E90740")]
	public void Init(Collider collider, NavMeshAgent agent)
	{
	}

	// Token: 0x06000C4F RID: 3151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0x1E908F0", Offset = "0x1E909F1", VA = "0x1E908F0")]
	private void Awake()
	{
	}

	// Token: 0x06000C50 RID: 3152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0x1E90D80", Offset = "0x1E90E81", VA = "0x1E90D80")]
	protected void Start()
	{
	}

	// Token: 0x06000C51 RID: 3153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0x1E90E20", Offset = "0x1E90F21", VA = "0x1E90E20")]
	public void OnEnable()
	{
	}

	// Token: 0x06000C52 RID: 3154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B00")]
	[Address(RVA = "0x1E90E30", Offset = "0x1E90F31", VA = "0x1E90E30")]
	public void OnDisable()
	{
	}

	// Token: 0x06000C53 RID: 3155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B01")]
	[Address(RVA = "0x1E90E40", Offset = "0x1E90F41", VA = "0x1E90E40", Slot = "4")]
	public virtual void Rotate(float angularSpeed, float deltaTime, bool onlyLateral = true)
	{
	}

	// Token: 0x06000C54 RID: 3156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B02")]
	[Address(RVA = "0x1E90FD0", Offset = "0x1E910D1", VA = "0x1E90FD0")]
	public void ResetOnGround()
	{
	}

	// Token: 0x06000C55 RID: 3157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B03")]
	[Address(RVA = "0x1E90FE0", Offset = "0x1E910E1", VA = "0x1E90FE0", Slot = "5")]
	public virtual void Move(float maxSpeed, float acceleration, float deceleration, float deltaTime, bool onlyLateral = true)
	{
	}

	// Token: 0x06000C56 RID: 3158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B04")]
	[Address(RVA = "0x1E92860", Offset = "0x1E92961", VA = "0x1E92860")]
	private void LimitLateralVelocity(float maxSpeed)
	{
	}

	// Token: 0x06000C57 RID: 3159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B05")]
	[Address(RVA = "0x1E91760", Offset = "0x1E91861", VA = "0x1E91760")]
	public void DetectGround(float deltaTime)
	{
	}

	// Token: 0x06000C58 RID: 3160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B06")]
	[Address(RVA = "0x1E92630", Offset = "0x1E92731", VA = "0x1E92630")]
	private void ApplyMovement(MovementVelocity velocity, Vector3 desiredVelocity, float maxSpeed, float acceleration, float deceleration, float deltaTime)
	{
	}

	// Token: 0x06000C59 RID: 3161 RVA: 0x00005EB0 File Offset: 0x000040B0
	[Token(Token = "0x6000B07")]
	[Address(RVA = "0x1E92EE0", Offset = "0x1E92FE1", VA = "0x1E92EE0")]
	public Vector3 MoveDeltaPosition(Vector3 deltaPosition, float deltaTime)
	{
		return default(Vector3);
	}

	// Token: 0x06000C5A RID: 3162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B08")]
	[Address(RVA = "0x1E92E10", Offset = "0x1E92F11", VA = "0x1E92E10")]
	public void ClearVelocityAll()
	{
	}

	// Token: 0x06000C5B RID: 3163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B09")]
	[Address(RVA = "0x1E94100", Offset = "0x1E94201", VA = "0x1E94100")]
	public void ClearVelocity(CharacterMovement.VelocityType type)
	{
	}

	// Token: 0x06000C5C RID: 3164 RVA: 0x00005EC8 File Offset: 0x000040C8
	[Token(Token = "0x6000B0A")]
	[Address(RVA = "0x1E941B0", Offset = "0x1E942B1", VA = "0x1E941B0")]
	public Vector3 GetVelocity(CharacterMovement.VelocityType type = CharacterMovement.VelocityType.Base)
	{
		return default(Vector3);
	}

	// Token: 0x06000C5D RID: 3165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0B")]
	[Address(RVA = "0x1E94200", Offset = "0x1E94301", VA = "0x1E94200")]
	public void SetVelocity(Vector3 velocity, CharacterMovement.VelocityType type = CharacterMovement.VelocityType.Base)
	{
	}

	// Token: 0x06000C5E RID: 3166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0C")]
	[Address(RVA = "0x1E94250", Offset = "0x1E94351", VA = "0x1E94250")]
	public void ClearForceAll()
	{
	}

	// Token: 0x06000C5F RID: 3167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0D")]
	[Address(RVA = "0x1E92DC0", Offset = "0x1E92EC1", VA = "0x1E92DC0")]
	public void ClearForce(CharacterMovement.VelocityType type = CharacterMovement.VelocityType.Base)
	{
	}

	// Token: 0x06000C60 RID: 3168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0E")]
	[Address(RVA = "0x1E91680", Offset = "0x1E91781", VA = "0x1E91680")]
	public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force, CharacterMovement.VelocityType type = CharacterMovement.VelocityType.Base)
	{
	}

	// Token: 0x06000C61 RID: 3169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0F")]
	[Address(RVA = "0x1E916D0", Offset = "0x1E917D1", VA = "0x1E916D0")]
	private void ApplyForceAll(float deltaTime)
	{
	}

	// Token: 0x06000C62 RID: 3170 RVA: 0x00005EE0 File Offset: 0x000040E0
	[Token(Token = "0x6000B10")]
	[Address(RVA = "0x1E92C60", Offset = "0x1E92D61", VA = "0x1E92C60")]
	protected bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float distance, LayerMask layerMask, float backstepDistance = 0.05f)
	{
		return default(bool);
	}

	// Token: 0x06000C63 RID: 3171 RVA: 0x00005EF8 File Offset: 0x000040F8
	[Token(Token = "0x6000B11")]
	[Address(RVA = "0x1E92A30", Offset = "0x1E92B31", VA = "0x1E92A30")]
	protected bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float distance, LayerMask layerMask, float backstepDistance = 0.05f)
	{
		return default(bool);
	}

	// Token: 0x06000C64 RID: 3172 RVA: 0x00005F10 File Offset: 0x00004110
	[Token(Token = "0x6000B12")]
	[Address(RVA = "0x1E93CA0", Offset = "0x1E93DA1", VA = "0x1E93CA0")]
	protected bool CapsuleCast(Vector3 bottom, Vector3 top, float radius, Vector3 direction, out RaycastHit hitInfo, float distance, LayerMask layerMask, float backstepDistance = 0.05f)
	{
		return default(bool);
	}

	// Token: 0x06000C65 RID: 3173 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B13")]
	[Address(RVA = "0x1E942C0", Offset = "0x1E943C1", VA = "0x1E942C0")]
	public Collider[] OverlapCapsule(Vector3 position, Quaternion rotation, out int overlapCount)
	{
		return null;
	}

	// Token: 0x06000C66 RID: 3174 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B14")]
	[Address(RVA = "0x1E94710", Offset = "0x1E94811", VA = "0x1E94710")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19B980", Offset = "0x19BA81")]
	private IEnumerator LateFixedUpdate()
	{
		return null;
	}

	// Token: 0x06000C67 RID: 3175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B15")]
	[Address(RVA = "0x1E947C0", Offset = "0x1E948C1", VA = "0x1E947C0")]
	private void OverlapRecovery(ref Vector3 probingPosition, Quaternion probingRotation)
	{
	}

	// Token: 0x06000C68 RID: 3176 RVA: 0x00005F28 File Offset: 0x00004128
	[Token(Token = "0x6000B16")]
	[Address(RVA = "0x1E94B80", Offset = "0x1E94C81", VA = "0x1E94B80")]
	public bool IsReverseMove(Vector3 vector)
	{
		return default(bool);
	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x00005F40 File Offset: 0x00004140
	[Token(Token = "0x6000B17")]
	[Address(RVA = "0x1E94D50", Offset = "0x1E94E51", VA = "0x1E94D50")]
	public float GetAcceleration()
	{
		return 0f;
	}

	// Token: 0x06000C6A RID: 3178 RVA: 0x00005F58 File Offset: 0x00004158
	[Token(Token = "0x6000B18")]
	[Address(RVA = "0x1E94F20", Offset = "0x1E95021", VA = "0x1E94F20")]
	public float GetRotateSpeed()
	{
		return 0f;
	}

	// Token: 0x06000C6B RID: 3179 RVA: 0x00005F70 File Offset: 0x00004170
	[Token(Token = "0x6000B19")]
	[Address(RVA = "0x1E94E40", Offset = "0x1E94F41", VA = "0x1E94E40")]
	public float GetAcceleration(float min, float max, float rate)
	{
		return 0f;
	}

	// Token: 0x06000C6C RID: 3180 RVA: 0x00005F88 File Offset: 0x00004188
	[Token(Token = "0x6000B1A")]
	[Address(RVA = "0x1E95020", Offset = "0x1E95121", VA = "0x1E95020")]
	public float GetRotateSpeed(float min, float max, float rate)
	{
		return 0f;
	}

	// Token: 0x06000C6D RID: 3181 RVA: 0x00005FA0 File Offset: 0x000041A0
	[Token(Token = "0x6000B1B")]
	[Address(RVA = "0x1E92550", Offset = "0x1E92651", VA = "0x1E92550")]
	public float CalcSlopRate(float min, float max, float slope)
	{
		return 0f;
	}

	// Token: 0x06000C6E RID: 3182 RVA: 0x00005FB8 File Offset: 0x000041B8
	[Token(Token = "0x6000B1C")]
	[Address(RVA = "0x1E92B90", Offset = "0x1E92C91", VA = "0x1E92B90")]
	public float GetSlopeDef()
	{
		return 0f;
	}

	// Token: 0x06000C6F RID: 3183 RVA: 0x00005FD0 File Offset: 0x000041D0
	[Token(Token = "0x6000B1D")]
	[Address(RVA = "0x1E92BB0", Offset = "0x1E92CB1", VA = "0x1E92BB0")]
	public float GetSlopeLimit(float elapsed)
	{
		return 0f;
	}

	// Token: 0x06000C70 RID: 3184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B1E")]
	[Address(RVA = "0x1E95100", Offset = "0x1E95201", VA = "0x1E95100")]
	public static void SwapMoveParam(MoveParamID id, CharacterMoveParam param)
	{
	}

	// Token: 0x06000C71 RID: 3185 RVA: 0x00005FE8 File Offset: 0x000041E8
	[Token(Token = "0x6000B1F")]
	[Address(RVA = "0x1E95340", Offset = "0x1E95441", VA = "0x1E95340")]
	public float GetLocomotionValue(float value)
	{
		return 0f;
	}

	// Token: 0x06000C72 RID: 3186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B20")]
	[Address(RVA = "0x1E953E0", Offset = "0x1E954E1", VA = "0x1E953E0")]
	public CharacterMovement()
	{
	}

	// Token: 0x04000720 RID: 1824
	[Token(Token = "0x40005C4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public CharacterMovement.MoveType moveType;

	// Token: 0x04000721 RID: 1825
	[Token(Token = "0x40005C5")]
	protected const float kBackstepDistance = 0.05f;

	// Token: 0x04000722 RID: 1826
	[Token(Token = "0x40005C6")]
	protected const float kMinCastDistance = 0.01f;

	// Token: 0x04000723 RID: 1827
	[Token(Token = "0x40005C7")]
	protected const float kMinLedgeDistance = 0.05f;

	// Token: 0x04000724 RID: 1828
	[Token(Token = "0x40005C8")]
	protected const float kMinStepOffset = 0.1f;

	// Token: 0x04000725 RID: 1829
	[Token(Token = "0x40005C9")]
	protected const float kHorizontalOffset = 0.001f;

	// Token: 0x04000726 RID: 1830
	[Token(Token = "0x40005CA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Collider[] OverlappedColliders;

	// Token: 0x04000727 RID: 1831
	[Token(Token = "0x40005CB")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	protected MoveParamID m_MoveParamID;

	// Token: 0x04000728 RID: 1832
	[Token(Token = "0x40005CC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected AnimationCurve m_LocomotionCurve;

	// Token: 0x04000729 RID: 1833
	[Token(Token = "0x40005CD")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool m_useGravity;

	// Token: 0x0400072A RID: 1834
	[Token(Token = "0x40005CE")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	protected float m_CastDistance;

	// Token: 0x0400072B RID: 1835
	[Token(Token = "0x40005CF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected float m_AirCastDistance;

	// Token: 0x0400072C RID: 1836
	[Token(Token = "0x40005D0")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	protected bool m_EnableDetectGround;

	// Token: 0x0400072D RID: 1837
	[Token(Token = "0x40005D1")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UnityEvent m_onLanding;

	// Token: 0x0400072E RID: 1838
	[Token(Token = "0x40005D2")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UnityEvent m_onFalling;

	// Token: 0x0400072F RID: 1839
	[Token(Token = "0x40005D3")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UnityEvent m_onSliding;

	// Token: 0x04000730 RID: 1840
	[Token(Token = "0x40005D4")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D9A0", Offset = "0x15DAA1")]
	private CharacterMoveParam <MoveParam>k__BackingField;

	// Token: 0x04000731 RID: 1841
	[Token(Token = "0x40005D5")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D9B0", Offset = "0x15DAB1")]
	private CharacterMoveSetting <MoveSetting>k__BackingField;

	// Token: 0x04000732 RID: 1842
	[Token(Token = "0x40005D6")]
	[FieldOffset(Offset = "0x60")]
	private float m_SlopeElapsed;

	// Token: 0x04000733 RID: 1843
	[Token(Token = "0x40005D7")]
	private const int kVelocityTypeLength = 3;

	// Token: 0x04000734 RID: 1844
	[Token(Token = "0x40005D8")]
	[FieldOffset(Offset = "0x68")]
	private MovementVelocity[] m_Velocity;

	// Token: 0x04000735 RID: 1845
	[Token(Token = "0x40005D9")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D9C0", Offset = "0x15DAC1")]
	private Character <Chara>k__BackingField;

	// Token: 0x04000736 RID: 1846
	[Token(Token = "0x40005DA")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D9D0", Offset = "0x15DAD1")]
	private NavMeshAgent <NavMeshAgent>k__BackingField;

	// Token: 0x04000737 RID: 1847
	[Token(Token = "0x40005DB")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D9E0", Offset = "0x15DAE1")]
	private CharacterController <CharacterController>k__BackingField;

	// Token: 0x04000738 RID: 1848
	[Token(Token = "0x40005DC")]
	[FieldOffset(Offset = "0x88")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D9F0", Offset = "0x15DAF1")]
	private Rigidbody <Rigidbody>k__BackingField;

	// Token: 0x04000739 RID: 1849
	[Token(Token = "0x40005DD")]
	[FieldOffset(Offset = "0x90")]
	private float m_LocomotionMinValue;

	// Token: 0x0400073A RID: 1850
	[Token(Token = "0x40005DE")]
	[FieldOffset(Offset = "0x94")]
	private bool m_isMove;

	// Token: 0x0400073B RID: 1851
	[Token(Token = "0x40005DF")]
	[FieldOffset(Offset = "0x95")]
	private bool m_isRotate;

	// Token: 0x0400073C RID: 1852
	[Token(Token = "0x40005E0")]
	[FieldOffset(Offset = "0x98")]
	private RaycastHit[] m_HitInfo;

	// Token: 0x0400073D RID: 1853
	[Token(Token = "0x40005E1")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DA00", Offset = "0x15DB01")]
	private bool <isValidGround>k__BackingField;

	// Token: 0x0400073E RID: 1854
	[Token(Token = "0x40005E2")]
	[FieldOffset(Offset = "0xA1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DA10", Offset = "0x15DB11")]
	private bool <isOnGround>k__BackingField;

	// Token: 0x0400073F RID: 1855
	[Token(Token = "0x40005E3")]
	[FieldOffset(Offset = "0xA2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DA20", Offset = "0x15DB21")]
	private bool <isOnStep>k__BackingField;

	// Token: 0x04000740 RID: 1856
	[Token(Token = "0x40005E4")]
	[FieldOffset(Offset = "0xA3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DA30", Offset = "0x15DB31")]
	private bool <isOnSlope>k__BackingField;

	// Token: 0x04000741 RID: 1857
	[Token(Token = "0x40005E5")]
	[FieldOffset(Offset = "0xA4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DA40", Offset = "0x15DB41")]
	private bool <wasOnGround>k__BackingField;

	// Token: 0x04000742 RID: 1858
	[Token(Token = "0x40005E6")]
	[FieldOffset(Offset = "0xA5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DA50", Offset = "0x15DB51")]
	private bool <wasOnStep>k__BackingField;

	// Token: 0x04000743 RID: 1859
	[Token(Token = "0x40005E7")]
	[FieldOffset(Offset = "0xA6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DA60", Offset = "0x15DB61")]
	private bool <wasOnSlope>k__BackingField;

	// Token: 0x04000744 RID: 1860
	[Token(Token = "0x40005E8")]
	[FieldOffset(Offset = "0xA7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DA70", Offset = "0x15DB71")]
	private bool <isFalling>k__BackingField;

	// Token: 0x04000745 RID: 1861
	[Token(Token = "0x40005E9")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DA80", Offset = "0x15DB81")]
	private Vector3 <GroundNormal>k__BackingField;

	// Token: 0x04000746 RID: 1862
	[Token(Token = "0x40005EA")]
	[FieldOffset(Offset = "0xB4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DA90", Offset = "0x15DB91")]
	private Vector3 <MoveDirection>k__BackingField;

	// Token: 0x04000747 RID: 1863
	[Token(Token = "0x40005EB")]
	[FieldOffset(Offset = "0xC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DAA0", Offset = "0x15DBA1")]
	private Vector3 <RotateDirection>k__BackingField;

	// Token: 0x04000748 RID: 1864
	[Token(Token = "0x40005EC")]
	[FieldOffset(Offset = "0xCC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DAB0", Offset = "0x15DBB1")]
	private Vector3 <VelocityAtLanding>k__BackingField;

	// Token: 0x04000749 RID: 1865
	[Token(Token = "0x40005ED")]
	[FieldOffset(Offset = "0xD8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DAC0", Offset = "0x15DBC1")]
	private Collider <CapsuleCollider>k__BackingField;

	// Token: 0x0400074A RID: 1866
	[Token(Token = "0x40005EE")]
	[FieldOffset(Offset = "0xE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DAD0", Offset = "0x15DBD1")]
	private float <capsuleRadius>k__BackingField;

	// Token: 0x0400074B RID: 1867
	[Token(Token = "0x40005EF")]
	[FieldOffset(Offset = "0xE4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DAE0", Offset = "0x15DBE1")]
	private float <capsuleHeight>k__BackingField;

	// Token: 0x0400074C RID: 1868
	[Token(Token = "0x40005F0")]
	[FieldOffset(Offset = "0xE8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DAF0", Offset = "0x15DBF1")]
	private Vector3 <capsuleCenter>k__BackingField;

	// Token: 0x0400074D RID: 1869
	[Token(Token = "0x40005F1")]
	[FieldOffset(Offset = "0xF4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DB00", Offset = "0x15DC01")]
	private float <capsuleSkinWidth>k__BackingField;

	// Token: 0x0400074E RID: 1870
	[Token(Token = "0x40005F2")]
	[FieldOffset(Offset = "0xF8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DB10", Offset = "0x15DC11")]
	private float <stepOffset>k__BackingField;

	// Token: 0x0400074F RID: 1871
	[Token(Token = "0x40005F3")]
	[FieldOffset(Offset = "0xFC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DB20", Offset = "0x15DC21")]
	private LayerMask <overlapMask>k__BackingField;

	// Token: 0x04000750 RID: 1872
	[Token(Token = "0x40005F4")]
	[FieldOffset(Offset = "0x100")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DB30", Offset = "0x15DC31")]
	private bool <enableEnemyCollision>k__BackingField;

	// Token: 0x04000751 RID: 1873
	[Token(Token = "0x40005F5")]
	[FieldOffset(Offset = "0x8")]
	public static float WalkMoveSpeed;

	// Token: 0x04000752 RID: 1874
	[Token(Token = "0x40005F6")]
	[FieldOffset(Offset = "0xC")]
	public static float CrystalMoveSpeed;

	// Token: 0x04000753 RID: 1875
	[Token(Token = "0x40005F7")]
	[FieldOffset(Offset = "0x10")]
	public static float InDoorMoveSpeed;

	// Token: 0x04000754 RID: 1876
	[Token(Token = "0x40005F8")]
	[FieldOffset(Offset = "0x14")]
	public static float InFarmMoveSpeed;

	// Token: 0x04000755 RID: 1877
	[Token(Token = "0x40005F9")]
	[FieldOffset(Offset = "0x18")]
	public static float ParalysisMoveSpeed;

	// Token: 0x04000756 RID: 1878
	[Token(Token = "0x40005FA")]
	[FieldOffset(Offset = "0x1C")]
	public static float OnSpiderFlatWebMoveSpeed;

	// Token: 0x0200021D RID: 541
	[Token(Token = "0x2000FEE")]
	public enum MoveType
	{
		// Token: 0x04000758 RID: 1880
		[Token(Token = "0x4018DD0")]
		CharactorController,
		// Token: 0x04000759 RID: 1881
		[Token(Token = "0x4018DD1")]
		RigidBody,
		// Token: 0x0400075A RID: 1882
		[Token(Token = "0x4018DD2")]
		NaviMesh
	}

	// Token: 0x0200021E RID: 542
	[Token(Token = "0x2000FEF")]
	public enum VelocityType
	{
		// Token: 0x0400075C RID: 1884
		[Token(Token = "0x4018DD4")]
		Base,
		// Token: 0x0400075D RID: 1885
		[Token(Token = "0x4018DD5")]
		Addition,
		// Token: 0x0400075E RID: 1886
		[Token(Token = "0x4018DD6")]
		Action
	}

	// Token: 0x0200021F RID: 543
	[Token(Token = "0x2000FF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157250", Offset = "0x157351")]
	private sealed class <LateFixedUpdate>d__180 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000C74 RID: 3188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C3D")]
		[Address(RVA = "0x1E94790", Offset = "0x1E94891", VA = "0x1E94790")]
		[DebuggerHidden]
		public <LateFixedUpdate>d__180(int <>1__state)
		{
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C3E")]
		[Address(RVA = "0x1E955A0", Offset = "0x1E956A1", VA = "0x1E955A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00006000 File Offset: 0x00004200
		[Token(Token = "0x6006C3F")]
		[Address(RVA = "0x1E955B0", Offset = "0x1E956B1", VA = "0x1E955B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BDA")]
		private object Current
		{
			[Token(Token = "0x6006C40")]
			[Address(RVA = "0x1E956E0", Offset = "0x1E957E1", VA = "0x1E956E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C41")]
		[Address(RVA = "0x1E956F0", Offset = "0x1E957F1", VA = "0x1E956F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BDB")]
		private object Current
		{
			[Token(Token = "0x6006C42")]
			[Address(RVA = "0x1E95750", Offset = "0x1E95851", VA = "0x1E95750", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400075F RID: 1887
		[Token(Token = "0x4018DD7")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000760 RID: 1888
		[Token(Token = "0x4018DD8")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000761 RID: 1889
		[Token(Token = "0x4018DD9")]
		[FieldOffset(Offset = "0x20")]
		public CharacterMovement <>4__this;

		// Token: 0x04000762 RID: 1890
		[Token(Token = "0x4018DDA")]
		[FieldOffset(Offset = "0x28")]
		private WaitForFixedUpdate <waitTime>5__2;
	}
}
