using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

// Token: 0x02000218 RID: 536
[Token(Token = "0x20001B4")]
[Attribute(Name = "DisallowMultipleComponent", RVA = "0x1458A0", Offset = "0x1459A1")]
[Attribute(Name = "DefaultExecutionOrder", RVA = "0x1458A0", Offset = "0x1459A1")]
public class Character : ActorController
{
	// Token: 0x06000B40 RID: 2880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F0")]
	[Address(RVA = "0x1E85AC0", Offset = "0x1E85BC1", VA = "0x1E85AC0", Slot = "20")]
	public virtual void OnEvent(int index)
	{
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F1")]
	[Address(RVA = "0x1E85B20", Offset = "0x1E85C21", VA = "0x1E85B20", Slot = "21")]
	public virtual void OnEvent(int index, int param)
	{
	}

	// Token: 0x06000B42 RID: 2882 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F2")]
	[Address(RVA = "0x1E85B80", Offset = "0x1E85C81", VA = "0x1E85B80", Slot = "22")]
	public virtual void OnEvent(int index, float param)
	{
	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F3")]
	[Address(RVA = "0x1E85BE0", Offset = "0x1E85CE1", VA = "0x1E85BE0", Slot = "23")]
	public virtual void OnEvent(int index, string param)
	{
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F4")]
	[Address(RVA = "0x1E80E90", Offset = "0x1E80F91", VA = "0x1E80E90", Slot = "24")]
	public virtual void OnEvent(int index, bool param)
	{
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009F5")]
	[Address(RVA = "0x1E85BF0", Offset = "0x1E85CF1", VA = "0x1E85BF0", Slot = "25")]
	public virtual void OnEvent(int index, UnityEngine.Object param)
	{
	}

	// Token: 0x170001FF RID: 511
	// (get) Token: 0x06000B46 RID: 2886 RVA: 0x00005778 File Offset: 0x00003978
	[Token(Token = "0x170001E2")]
	public override bool IsActive
	{
		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x1E85C50", Offset = "0x1E85D51", VA = "0x1E85C50", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000200 RID: 512
	// (get) Token: 0x06000B47 RID: 2887 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001E3")]
	public virtual CharacterStatusBase Status
	{
		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x1E85CE0", Offset = "0x1E85DE1", VA = "0x1E85CE0", Slot = "26")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B2F0", Offset = "0x19B3F1")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000201 RID: 513
	// (get) Token: 0x06000B48 RID: 2888 RVA: 0x00005790 File Offset: 0x00003990
	[Token(Token = "0x170001E4")]
	public virtual bool IsDead
	{
		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x1E85CF0", Offset = "0x1E85DF1", VA = "0x1E85CF0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000202 RID: 514
	// (get) Token: 0x06000B49 RID: 2889 RVA: 0x000057A8 File Offset: 0x000039A8
	[Token(Token = "0x170001E5")]
	public virtual bool IsInvincible
	{
		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x1E85D50", Offset = "0x1E85E51", VA = "0x1E85D50", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000203 RID: 515
	// (get) Token: 0x06000B4A RID: 2890 RVA: 0x000057C0 File Offset: 0x000039C0
	// (set) Token: 0x06000B4B RID: 2891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001E6")]
	public float InvincibleTimer
	{
		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x1E85DD0", Offset = "0x1E85ED1", VA = "0x1E85DD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B300", Offset = "0x19B401")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x1E85DE0", Offset = "0x1E85EE1", VA = "0x1E85DE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B310", Offset = "0x19B411")]
		private set
		{
		}
	}

	// Token: 0x17000204 RID: 516
	// (get) Token: 0x06000B4C RID: 2892 RVA: 0x000057D8 File Offset: 0x000039D8
	[Token(Token = "0x170001E7")]
	public override Alliance Alliance
	{
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x1E85DF0", Offset = "0x1E85EF1", VA = "0x1E85DF0", Slot = "8")]
		get
		{
			return Alliance.None;
		}
	}

	// Token: 0x17000205 RID: 517
	// (get) Token: 0x06000B4D RID: 2893 RVA: 0x000057F0 File Offset: 0x000039F0
	[Token(Token = "0x170001E8")]
	public virtual Parameter Parameter
	{
		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x1E85E50", Offset = "0x1E85F51", VA = "0x1E85E50", Slot = "29")]
		get
		{
			return default(Parameter);
		}
	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x00005808 File Offset: 0x00003A08
	[Token(Token = "0x60009FE")]
	[Address(RVA = "0x1E85EC0", Offset = "0x1E85FC1", VA = "0x1E85EC0", Slot = "9")]
	public override bool IsCanNotLockon(CharacterBase lockonCharacter)
	{
		return default(bool);
	}

	// Token: 0x17000206 RID: 518
	// (get) Token: 0x06000B4F RID: 2895 RVA: 0x00005820 File Offset: 0x00003A20
	[Token(Token = "0x170001E9")]
	public override Vector3 GetTakeLockonPos
	{
		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x1E85F90", Offset = "0x1E86091", VA = "0x1E85F90", Slot = "10")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000207 RID: 519
	// (get) Token: 0x06000B50 RID: 2896 RVA: 0x00005838 File Offset: 0x00003A38
	// (set) Token: 0x06000B51 RID: 2897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001EA")]
	public virtual bool IsShortPlay
	{
		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x1E86140", Offset = "0x1E86241", VA = "0x1E86140", Slot = "30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x1E86150", Offset = "0x1E86251", VA = "0x1E86150", Slot = "31")]
		set
		{
		}
	}

	// Token: 0x17000208 RID: 520
	// (get) Token: 0x06000B52 RID: 2898 RVA: 0x00005850 File Offset: 0x00003A50
	// (set) Token: 0x06000B53 RID: 2899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001EB")]
	public virtual bool IsShortPlayMove
	{
		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x1E86180", Offset = "0x1E86281", VA = "0x1E86180", Slot = "32")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B320", Offset = "0x19B421")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x1E86190", Offset = "0x1E86291", VA = "0x1E86190", Slot = "33")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B330", Offset = "0x19B431")]
		set
		{
		}
	}

	// Token: 0x17000209 RID: 521
	// (get) Token: 0x06000B54 RID: 2900 RVA: 0x00005868 File Offset: 0x00003A68
	// (set) Token: 0x06000B55 RID: 2901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001EC")]
	public Vector3 ShortPlayTargetPosition
	{
		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x1E861A0", Offset = "0x1E862A1", VA = "0x1E861A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B340", Offset = "0x19B441")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x1E861B0", Offset = "0x1E862B1", VA = "0x1E861B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B350", Offset = "0x19B451")]
		set
		{
		}
	}

	// Token: 0x1700020A RID: 522
	// (get) Token: 0x06000B56 RID: 2902 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B57 RID: 2903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001ED")]
	public CharacterBase LockedTarget
	{
		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x1E861C0", Offset = "0x1E862C1", VA = "0x1E861C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B360", Offset = "0x19B461")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x1E861D0", Offset = "0x1E862D1", VA = "0x1E861D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B370", Offset = "0x19B471")]
		protected set
		{
		}
	}

	// Token: 0x1700020B RID: 523
	// (get) Token: 0x06000B58 RID: 2904 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B59 RID: 2905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001EE")]
	public CharacterAnimationParam AnimationParam
	{
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x1E861E0", Offset = "0x1E862E1", VA = "0x1E861E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B380", Offset = "0x19B481")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x1E861F0", Offset = "0x1E862F1", VA = "0x1E861F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B390", Offset = "0x19B491")]
		set
		{
		}
	}

	// Token: 0x1700020C RID: 524
	// (get) Token: 0x06000B5A RID: 2906 RVA: 0x00005880 File Offset: 0x00003A80
	// (set) Token: 0x06000B5B RID: 2907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001EF")]
	public float Locomotion
	{
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x1E86200", Offset = "0x1E86301", VA = "0x1E86200")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B3A0", Offset = "0x19B4A1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x1E86210", Offset = "0x1E86311", VA = "0x1E86210")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B3B0", Offset = "0x19B4B1")]
		set
		{
		}
	}

	// Token: 0x1700020D RID: 525
	// (get) Token: 0x06000B5C RID: 2908 RVA: 0x00005898 File Offset: 0x00003A98
	[Token(Token = "0x170001F0")]
	public virtual bool IsBattleMode
	{
		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x1E86220", Offset = "0x1E86321", VA = "0x1E86220", Slot = "34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B3C0", Offset = "0x19B4C1")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700020E RID: 526
	// (get) Token: 0x06000B5D RID: 2909 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B5E RID: 2910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F1")]
	public NavMeshAgent NavMeshAgent
	{
		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x1E86230", Offset = "0x1E86331", VA = "0x1E86230")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B3D0", Offset = "0x19B4D1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x1E86240", Offset = "0x1E86341", VA = "0x1E86240")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B3E0", Offset = "0x19B4E1")]
		protected set
		{
		}
	}

	// Token: 0x1700020F RID: 527
	// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B60 RID: 2912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F2")]
	protected CharacterController CharacterController
	{
		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x1E86250", Offset = "0x1E86351", VA = "0x1E86250")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B3F0", Offset = "0x19B4F1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x1E86260", Offset = "0x1E86361", VA = "0x1E86260")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B400", Offset = "0x19B501")]
		set
		{
		}
	}

	// Token: 0x17000210 RID: 528
	// (get) Token: 0x06000B61 RID: 2913 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B62 RID: 2914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F3")]
	public ActionScriptControllerBase ActionScriptControllerBase
	{
		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x1E86270", Offset = "0x1E86371", VA = "0x1E86270")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B410", Offset = "0x19B511")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x1E86280", Offset = "0x1E86381", VA = "0x1E86280")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B420", Offset = "0x19B521")]
		private set
		{
		}
	}

	// Token: 0x17000211 RID: 529
	// (get) Token: 0x06000B63 RID: 2915 RVA: 0x000058B0 File Offset: 0x00003AB0
	[Token(Token = "0x170001F4")]
	public bool IsPC
	{
		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x1E86290", Offset = "0x1E86391", VA = "0x1E86290")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000212 RID: 530
	// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F5")]
	public InteractionCollider InteractionCollider
	{
		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x1E86340", Offset = "0x1E86441", VA = "0x1E86340")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000213 RID: 531
	// (get) Token: 0x06000B65 RID: 2917 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B66 RID: 2918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F6")]
	public CharacterMovement Movement
	{
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x1E86480", Offset = "0x1E86581", VA = "0x1E86480")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x1E86490", Offset = "0x1E86591", VA = "0x1E86490")]
		protected set
		{
		}
	}

	// Token: 0x17000214 RID: 532
	// (get) Token: 0x06000B67 RID: 2919 RVA: 0x000058C8 File Offset: 0x00003AC8
	[Token(Token = "0x170001F7")]
	public bool IsGrounded
	{
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x1E864A0", Offset = "0x1E865A1", VA = "0x1E864A0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000215 RID: 533
	// (get) Token: 0x06000B68 RID: 2920 RVA: 0x000058E0 File Offset: 0x00003AE0
	[Token(Token = "0x170001F8")]
	public bool IsDamageAction
	{
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x1E86540", Offset = "0x1E86641", VA = "0x1E86540")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000216 RID: 534
	// (get) Token: 0x06000B69 RID: 2921 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B6A RID: 2922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F9")]
	public DamageActionController DamageAction
	{
		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x1E865E0", Offset = "0x1E866E1", VA = "0x1E865E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x1E865F0", Offset = "0x1E866F1", VA = "0x1E865F0")]
		protected set
		{
		}
	}

	// Token: 0x17000217 RID: 535
	// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B6C RID: 2924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001FA")]
	public ActorVoiceController VoiceController
	{
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x1E86600", Offset = "0x1E86701", VA = "0x1E86600")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x1E86610", Offset = "0x1E86711", VA = "0x1E86610")]
		protected set
		{
		}
	}

	// Token: 0x17000218 RID: 536
	// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B6E RID: 2926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001FB")]
	public RestraintController Restraint
	{
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x1E86620", Offset = "0x1E86721", VA = "0x1E86620")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x1E86630", Offset = "0x1E86731", VA = "0x1E86630")]
		protected set
		{
		}
	}

	// Token: 0x17000219 RID: 537
	// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B70 RID: 2928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001FC")]
	public SlowStateController SlowState
	{
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x1E86640", Offset = "0x1E86741", VA = "0x1E86640")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x1E86650", Offset = "0x1E86751", VA = "0x1E86650")]
		protected set
		{
		}
	}

	// Token: 0x1700021A RID: 538
	// (get) Token: 0x06000B71 RID: 2929 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B72 RID: 2930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001FD")]
	public FootSteps FootSteps
	{
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x1E86660", Offset = "0x1E86761", VA = "0x1E86660")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x1E86670", Offset = "0x1E86771", VA = "0x1E86670")]
		protected set
		{
		}
	}

	// Token: 0x1700021B RID: 539
	// (get) Token: 0x06000B73 RID: 2931 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B74 RID: 2932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001FE")]
	public CharaFaceController FaceController
	{
		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x1E86680", Offset = "0x1E86781", VA = "0x1E86680")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x1E86690", Offset = "0x1E86791", VA = "0x1E86690")]
		protected set
		{
		}
	}

	// Token: 0x1700021C RID: 540
	// (get) Token: 0x06000B75 RID: 2933 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B76 RID: 2934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001FF")]
	public MagicMotionController MagicMotion
	{
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x1E866A0", Offset = "0x1E867A1", VA = "0x1E866A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x1E866B0", Offset = "0x1E867B1", VA = "0x1E866B0")]
		protected set
		{
		}
	}

	// Token: 0x1700021D RID: 541
	// (get) Token: 0x06000B77 RID: 2935 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B78 RID: 2936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000200")]
	public EscapeController Escape
	{
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x1E866C0", Offset = "0x1E867C1", VA = "0x1E866C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x1E866D0", Offset = "0x1E867D1", VA = "0x1E866D0")]
		protected set
		{
		}
	}

	// Token: 0x1700021E RID: 542
	// (get) Token: 0x06000B79 RID: 2937 RVA: 0x000058F8 File Offset: 0x00003AF8
	[Token(Token = "0x17000201")]
	public bool IsEscaping
	{
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x1E866E0", Offset = "0x1E867E1", VA = "0x1E866E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700021F RID: 543
	// (get) Token: 0x06000B7A RID: 2938 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B7B RID: 2939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000202")]
	public RideController RideController
	{
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x1E86780", Offset = "0x1E86881", VA = "0x1E86780")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x1E86790", Offset = "0x1E86891", VA = "0x1E86790")]
		protected set
		{
		}
	}

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x06000B7C RID: 2940 RVA: 0x00005910 File Offset: 0x00003B10
	[Token(Token = "0x17000203")]
	public bool IsRiding
	{
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x1E867A0", Offset = "0x1E868A1", VA = "0x1E867A0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000221 RID: 545
	// (get) Token: 0x06000B7D RID: 2941 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B7E RID: 2942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000204")]
	public LazyController LazyController
	{
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x1E86840", Offset = "0x1E86941", VA = "0x1E86840")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x1E86850", Offset = "0x1E86951", VA = "0x1E86850")]
		protected set
		{
		}
	}

	// Token: 0x17000222 RID: 546
	// (get) Token: 0x06000B7F RID: 2943 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B80 RID: 2944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000205")]
	public PersonalMotionController PersonalMotion
	{
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x1E86860", Offset = "0x1E86961", VA = "0x1E86860")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x1E86870", Offset = "0x1E86971", VA = "0x1E86870")]
		protected set
		{
		}
	}

	// Token: 0x17000223 RID: 547
	// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B82 RID: 2946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000206")]
	public SuperArmorController SuperArmor
	{
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x1E86880", Offset = "0x1E86981", VA = "0x1E86880")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x1E86890", Offset = "0x1E86991", VA = "0x1E86890")]
		protected set
		{
		}
	}

	// Token: 0x17000224 RID: 548
	// (get) Token: 0x06000B83 RID: 2947 RVA: 0x00005928 File Offset: 0x00003B28
	[Token(Token = "0x17000207")]
	public bool IsSuperArmor
	{
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x1E868A0", Offset = "0x1E869A1", VA = "0x1E868A0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000225 RID: 549
	// (get) Token: 0x06000B84 RID: 2948 RVA: 0x00005940 File Offset: 0x00003B40
	[Token(Token = "0x17000208")]
	public virtual bool IsItemHold
	{
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x1E86940", Offset = "0x1E86A41", VA = "0x1E86940", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000226 RID: 550
	// (get) Token: 0x06000B85 RID: 2949 RVA: 0x00005958 File Offset: 0x00003B58
	// (set) Token: 0x06000B86 RID: 2950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000209")]
	public Vector3 DeltaPosition
	{
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x1E86950", Offset = "0x1E86A51", VA = "0x1E86950")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B430", Offset = "0x19B531")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x1E86960", Offset = "0x1E86A61", VA = "0x1E86960")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B440", Offset = "0x19B541")]
		set
		{
		}
	}

	// Token: 0x17000227 RID: 551
	// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00005970 File Offset: 0x00003B70
	// (set) Token: 0x06000B88 RID: 2952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700020A")]
	public Quaternion DeltRotation
	{
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x1E86970", Offset = "0x1E86A71", VA = "0x1E86970")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B450", Offset = "0x19B551")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x1E86980", Offset = "0x1E86A81", VA = "0x1E86980")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B460", Offset = "0x19B561")]
		set
		{
		}
	}

	// Token: 0x17000228 RID: 552
	// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00005988 File Offset: 0x00003B88
	// (set) Token: 0x06000B8A RID: 2954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700020B")]
	public bool InFarm
	{
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x1E869A0", Offset = "0x1E86AA1", VA = "0x1E869A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B470", Offset = "0x19B571")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x1E869B0", Offset = "0x1E86AB1", VA = "0x1E869B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B480", Offset = "0x19B581")]
		set
		{
		}
	}

	// Token: 0x17000229 RID: 553
	// (get) Token: 0x06000B8B RID: 2955 RVA: 0x000059A0 File Offset: 0x00003BA0
	// (set) Token: 0x06000B8C RID: 2956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700020C")]
	public int InDoorCnt
	{
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x1E869C0", Offset = "0x1E86AC1", VA = "0x1E869C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B490", Offset = "0x19B591")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x1E869D0", Offset = "0x1E86AD1", VA = "0x1E869D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B4A0", Offset = "0x19B5A1")]
		set
		{
		}
	}

	// Token: 0x1700022A RID: 554
	// (get) Token: 0x06000B8D RID: 2957 RVA: 0x000059B8 File Offset: 0x00003BB8
	// (set) Token: 0x06000B8E RID: 2958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700020D")]
	public bool IsFreeseXZRootMotion
	{
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x1E869E0", Offset = "0x1E86AE1", VA = "0x1E869E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B4B0", Offset = "0x19B5B1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x1E869F0", Offset = "0x1E86AF1", VA = "0x1E869F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B4C0", Offset = "0x19B5C1")]
		set
		{
		}
	}

	// Token: 0x1700022B RID: 555
	// (get) Token: 0x06000B8F RID: 2959 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B90 RID: 2960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700020E")]
	public Transform EffectPoint
	{
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x1E86A00", Offset = "0x1E86B01", VA = "0x1E86A00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B4D0", Offset = "0x19B5D1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x1E86A10", Offset = "0x1E86B11", VA = "0x1E86A10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B4E0", Offset = "0x19B5E1")]
		set
		{
		}
	}

	// Token: 0x1700022C RID: 556
	// (get) Token: 0x06000B91 RID: 2961 RVA: 0x000059D0 File Offset: 0x00003BD0
	[Token(Token = "0x1700020F")]
	protected virtual bool KeepAnimatorControllerStateOnDisable
	{
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x1E86A20", Offset = "0x1E86B21", VA = "0x1E86A20", Slot = "36")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700022D RID: 557
	// (set) Token: 0x06000B92 RID: 2962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000210")]
	public virtual float LookIKWeight
	{
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x1E86A30", Offset = "0x1E86B31", VA = "0x1E86A30", Slot = "37")]
		set
		{
		}
	}

	// Token: 0x1700022E RID: 558
	// (get) Token: 0x06000B93 RID: 2963 RVA: 0x000059E8 File Offset: 0x00003BE8
	[Token(Token = "0x17000211")]
	protected virtual bool UseGravityOnNavMeshEnabled
	{
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x1E86A40", Offset = "0x1E86B41", VA = "0x1E86A40", Slot = "38")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000B94 RID: 2964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A44")]
	[Address(RVA = "0x1E86A50", Offset = "0x1E86B51", VA = "0x1E86A50", Slot = "11")]
	protected override void Awake()
	{
	}

	// Token: 0x06000B95 RID: 2965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A45")]
	[Address(RVA = "0x1E86F70", Offset = "0x1E87071", VA = "0x1E86F70", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x06000B96 RID: 2966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A46")]
	[Address(RVA = "0x1E87290", Offset = "0x1E87391", VA = "0x1E87290")]
	private void OnAnimatorMove()
	{
	}

	// Token: 0x06000B97 RID: 2967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A47")]
	[Address(RVA = "0x1E873E0", Offset = "0x1E874E1", VA = "0x1E873E0", Slot = "39")]
	protected virtual void Update()
	{
	}

	// Token: 0x06000B98 RID: 2968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A48")]
	[Address(RVA = "0x1E878D0", Offset = "0x1E879D1", VA = "0x1E878D0", Slot = "40")]
	protected virtual void LateUpdate()
	{
	}

	// Token: 0x06000B99 RID: 2969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A49")]
	[Address(RVA = "0x1E87B90", Offset = "0x1E87C91", VA = "0x1E87B90", Slot = "41")]
	protected virtual void FixedUpdate()
	{
	}

	// Token: 0x06000B9A RID: 2970 RVA: 0x00005A00 File Offset: 0x00003C00
	[Token(Token = "0x6000A4A")]
	[Address(RVA = "0x1E87D40", Offset = "0x1E87E41", VA = "0x1E87D40", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06000B9B RID: 2971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A4B")]
	[Address(RVA = "0x1E87E60", Offset = "0x1E87F61", VA = "0x1E87E60", Slot = "42")]
	public virtual void PlayMotion(string name, float fadeTime = 0f)
	{
	}

	// Token: 0x06000B9C RID: 2972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A4C")]
	[Address(RVA = "0x1E87E90", Offset = "0x1E87F91", VA = "0x1E87E90", Slot = "43")]
	public virtual void RePlayMotion(string name, float fadeTime = 0f)
	{
	}

	// Token: 0x06000B9D RID: 2973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A4D")]
	[Address(RVA = "0x1E87ED0", Offset = "0x1E87FD1", VA = "0x1E87ED0")]
	public void PlayFaceMotion(FaceType faceType)
	{
	}

	// Token: 0x06000B9E RID: 2974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A4E")]
	[Address(RVA = "0x1E87F90", Offset = "0x1E88091", VA = "0x1E87F90")]
	public void SetAnimatorParam(string name, int value)
	{
	}

	// Token: 0x06000B9F RID: 2975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A4F")]
	[Address(RVA = "0x1E881F0", Offset = "0x1E882F1", VA = "0x1E881F0")]
	public void SetAnimatorParam(string name, float value)
	{
	}

	// Token: 0x06000BA0 RID: 2976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A50")]
	[Address(RVA = "0x1E88320", Offset = "0x1E88421", VA = "0x1E88320")]
	public void SetAnimatorParam(string name, bool value)
	{
	}

	// Token: 0x06000BA1 RID: 2977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A51")]
	[Address(RVA = "0x1E88440", Offset = "0x1E88541", VA = "0x1E88440")]
	public void SetAnimatorParam(string name)
	{
	}

	// Token: 0x06000BA2 RID: 2978 RVA: 0x00005A18 File Offset: 0x00003C18
	[Token(Token = "0x6000A52")]
	[Address(RVA = "0x1E88550", Offset = "0x1E88651", VA = "0x1E88550")]
	public bool TryGetAnimatorParamBool(string name, out bool value)
	{
		return default(bool);
	}

	// Token: 0x06000BA3 RID: 2979 RVA: 0x00005A30 File Offset: 0x00003C30
	[Token(Token = "0x6000A53")]
	[Address(RVA = "0x1E886A0", Offset = "0x1E887A1", VA = "0x1E886A0")]
	public bool TryGetAnimatorParamFloat(string name, out float value)
	{
		return default(bool);
	}

	// Token: 0x06000BA4 RID: 2980 RVA: 0x00005A48 File Offset: 0x00003C48
	[Token(Token = "0x6000A54")]
	[Address(RVA = "0x1E87200", Offset = "0x1E87301", VA = "0x1E87200")]
	public bool TryAddHashParam(string name)
	{
		return default(bool);
	}

	// Token: 0x06000BA5 RID: 2981 RVA: 0x00005A60 File Offset: 0x00003C60
	[Token(Token = "0x6000A55")]
	[Address(RVA = "0x1E880B0", Offset = "0x1E881B1", VA = "0x1E880B0")]
	public int GetAnimatorParamHash(string name)
	{
		return 0;
	}

	// Token: 0x06000BA6 RID: 2982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A56")]
	[Address(RVA = "0x1E887F0", Offset = "0x1E888F1", VA = "0x1E887F0", Slot = "44")]
	protected virtual void InitAnimator()
	{
	}

	// Token: 0x06000BA7 RID: 2983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A57")]
	[Address(RVA = "0x1E888F0", Offset = "0x1E889F1", VA = "0x1E888F0", Slot = "45")]
	protected virtual void UpdateLocomotion(float deltaTime)
	{
	}

	// Token: 0x06000BA8 RID: 2984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A58")]
	[Address(RVA = "0x1E88B30", Offset = "0x1E88C31", VA = "0x1E88B30", Slot = "46")]
	protected virtual void SetLocomotion(float value)
	{
	}

	// Token: 0x06000BA9 RID: 2985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A59")]
	[Address(RVA = "0x1E88BA0", Offset = "0x1E88CA1", VA = "0x1E88BA0", Slot = "47")]
	protected virtual void OnWince()
	{
	}

	// Token: 0x06000BAA RID: 2986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5A")]
	[Address(RVA = "0x1E88BB0", Offset = "0x1E88CB1", VA = "0x1E88BB0")]
	public void SetFreeseXZRootMotionTimer(float time)
	{
	}

	// Token: 0x06000BAB RID: 2987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5B")]
	[Address(RVA = "0x1E88BC0", Offset = "0x1E88CC1", VA = "0x1E88BC0")]
	public void StopMove()
	{
	}

	// Token: 0x06000BAC RID: 2988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5C")]
	[Address(RVA = "0x1E88E40", Offset = "0x1E88F41", VA = "0x1E88E40")]
	public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force)
	{
	}

	// Token: 0x06000BAD RID: 2989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5D")]
	[Address(RVA = "0x1E88E60", Offset = "0x1E88F61", VA = "0x1E88E60")]
	public void ClearForce()
	{
	}

	// Token: 0x06000BAE RID: 2990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5E")]
	[Address(RVA = "0x1E88C40", Offset = "0x1E88D41", VA = "0x1E88C40")]
	public void ClearVelocity()
	{
	}

	// Token: 0x06000BAF RID: 2991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5F")]
	[Address(RVA = "0x1E88F80", Offset = "0x1E89081", VA = "0x1E88F80")]
	public void ClearVelocity(CharacterMovement.VelocityType velocityType)
	{
	}

	// Token: 0x06000BB0 RID: 2992 RVA: 0x00005A78 File Offset: 0x00003C78
	[Token(Token = "0x6000A60")]
	[Address(RVA = "0x1E89040", Offset = "0x1E89141", VA = "0x1E89040", Slot = "48")]
	public virtual bool InputMove(Vector3 vector)
	{
		return default(bool);
	}

	// Token: 0x06000BB1 RID: 2993 RVA: 0x00005A90 File Offset: 0x00003C90
	[Token(Token = "0x6000A61")]
	[Address(RVA = "0x1E891B0", Offset = "0x1E892B1", VA = "0x1E891B0")]
	public bool MovePosition(Vector3 vector)
	{
		return default(bool);
	}

	// Token: 0x06000BB2 RID: 2994 RVA: 0x00005AA8 File Offset: 0x00003CA8
	[Token(Token = "0x6000A62")]
	[Address(RVA = "0x1E892C0", Offset = "0x1E893C1", VA = "0x1E892C0")]
	public bool Rotate(Vector3 vector)
	{
		return default(bool);
	}

	// Token: 0x06000BB3 RID: 2995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A63")]
	[Address(RVA = "0x1E893D0", Offset = "0x1E894D1", VA = "0x1E893D0", Slot = "49")]
	protected virtual void ResetMovement()
	{
	}

	// Token: 0x06000BB4 RID: 2996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A64")]
	[Address(RVA = "0x1E89560", Offset = "0x1E89661", VA = "0x1E89560", Slot = "50")]
	protected virtual void UpdateMove(float deltaTime)
	{
	}

	// Token: 0x06000BB5 RID: 2997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A65")]
	[Address(RVA = "0x1E897D0", Offset = "0x1E898D1", VA = "0x1E897D0")]
	public void PushPosition(Vector3 pushVector)
	{
	}

	// Token: 0x06000BB6 RID: 2998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A66")]
	[Address(RVA = "0x1E89830", Offset = "0x1E89931", VA = "0x1E89830", Slot = "51")]
	protected virtual void UpdateRotate(float deltaTime)
	{
	}

	// Token: 0x06000BB7 RID: 2999 RVA: 0x00005AC0 File Offset: 0x00003CC0
	[Token(Token = "0x6000A67")]
	[Address(RVA = "0x1E898E0", Offset = "0x1E899E1", VA = "0x1E898E0", Slot = "52")]
	protected virtual float GetSlowMoveScale()
	{
		return 0f;
	}

	// Token: 0x06000BB8 RID: 3000 RVA: 0x00005AD8 File Offset: 0x00003CD8
	[Token(Token = "0x6000A68")]
	[Address(RVA = "0x1E89BC0", Offset = "0x1E89CC1", VA = "0x1E89BC0", Slot = "53")]
	protected virtual float GetMoveSpeedMax()
	{
		return 0f;
	}

	// Token: 0x06000BB9 RID: 3001 RVA: 0x00005AF0 File Offset: 0x00003CF0
	[Token(Token = "0x6000A69")]
	[Address(RVA = "0x1E89C10", Offset = "0x1E89D11", VA = "0x1E89C10")]
	protected float GetMoveSpeedMaxEquipAttribute(float speed)
	{
		return 0f;
	}

	// Token: 0x06000BBA RID: 3002 RVA: 0x00005B08 File Offset: 0x00003D08
	[Token(Token = "0x6000A6A")]
	[Address(RVA = "0x1E89E90", Offset = "0x1E89F91", VA = "0x1E89E90", Slot = "54")]
	protected virtual float GetMoveAcceleration()
	{
		return 0f;
	}

	// Token: 0x06000BBB RID: 3003 RVA: 0x00005B20 File Offset: 0x00003D20
	[Token(Token = "0x6000A6B")]
	[Address(RVA = "0x1E89EE0", Offset = "0x1E89FE1", VA = "0x1E89EE0")]
	protected float GetMoveAccelerationEquipAttribute(float speed)
	{
		return 0f;
	}

	// Token: 0x06000BBC RID: 3004 RVA: 0x00005B38 File Offset: 0x00003D38
	[Token(Token = "0x6000A6C")]
	[Address(RVA = "0x1E89FC0", Offset = "0x1E8A0C1", VA = "0x1E89FC0", Slot = "55")]
	protected virtual float GetMoveDeceleration()
	{
		return 0f;
	}

	// Token: 0x06000BBD RID: 3005 RVA: 0x00005B50 File Offset: 0x00003D50
	[Token(Token = "0x6000A6D")]
	[Address(RVA = "0x1E89FF0", Offset = "0x1E8A0F1", VA = "0x1E89FF0", Slot = "56")]
	public virtual float GetRotateSpeed()
	{
		return 0f;
	}

	// Token: 0x06000BBE RID: 3006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6E")]
	[Address(RVA = "0x1E8A1D0", Offset = "0x1E8A2D1", VA = "0x1E8A1D0", Slot = "57")]
	public virtual void StartBattleMode()
	{
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6F")]
	[Address(RVA = "0x1E8A1E0", Offset = "0x1E8A2E1", VA = "0x1E8A1E0", Slot = "58")]
	public virtual void EndBattleMode()
	{
	}

	// Token: 0x06000BC0 RID: 3008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A70")]
	[Address(RVA = "0x1E8A1F0", Offset = "0x1E8A2F1", VA = "0x1E8A1F0", Slot = "59")]
	public virtual void ForceEndBattleMode()
	{
	}

	// Token: 0x06000BC1 RID: 3009 RVA: 0x00005B68 File Offset: 0x00003D68
	[Token(Token = "0x6000A71")]
	[Address(RVA = "0x1E8A200", Offset = "0x1E8A301", VA = "0x1E8A200")]
	public bool Lockon()
	{
		return default(bool);
	}

	// Token: 0x06000BC2 RID: 3010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A72")]
	[Address(RVA = "0x1E8A8B0", Offset = "0x1E8A9B1", VA = "0x1E8A8B0")]
	public void LockonChange(bool checkRight, [Optional] Action lockonCallback)
	{
	}

	// Token: 0x06000BC3 RID: 3011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A73")]
	[Address(RVA = "0x1E8AF40", Offset = "0x1E8B041", VA = "0x1E8AF40")]
	public void ApproachEnemy(float force, CharacterBase target, float angle = 0f)
	{
	}

	// Token: 0x06000BC4 RID: 3012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A74")]
	[Address(RVA = "0x1E8A7A0", Offset = "0x1E8A8A1", VA = "0x1E8A7A0")]
	public void SetLockonTarget(CharacterBase characterBase)
	{
	}

	// Token: 0x06000BC5 RID: 3013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A75")]
	[Address(RVA = "0x1E8A8A0", Offset = "0x1E8A9A1", VA = "0x1E8A8A0")]
	public void ClearLockonTarget()
	{
	}

	// Token: 0x06000BC6 RID: 3014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A76")]
	[Address(RVA = "0x1E875B0", Offset = "0x1E876B1", VA = "0x1E875B0")]
	private void UpdateLockon()
	{
	}

	// Token: 0x06000BC7 RID: 3015 RVA: 0x00005B80 File Offset: 0x00003D80
	[Token(Token = "0x6000A77")]
	[Address(RVA = "0x1E8B990", Offset = "0x1E8BA91", VA = "0x1E8B990", Slot = "60")]
	protected virtual bool CheckEnemySearchList(CharacterBase characterBase)
	{
		return default(bool);
	}

	// Token: 0x06000BC8 RID: 3016 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A78")]
	protected List<CharacterBase> GetEnemySearchList<T>(float radius) where T : CharacterBase
	{
		return null;
	}

	// Token: 0x06000BC9 RID: 3017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A79")]
	[Address(RVA = "0x1E8BA40", Offset = "0x1E8BB41", VA = "0x1E8BA40", Slot = "61")]
	public virtual void SetGrounderIKWeight(float weight)
	{
	}

	// Token: 0x06000BCA RID: 3018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7A")]
	[Address(RVA = "0x1E8BA50", Offset = "0x1E8BB51", VA = "0x1E8BA50", Slot = "62")]
	public virtual void SetLookIKWeight(float weight)
	{
	}

	// Token: 0x06000BCB RID: 3019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7B")]
	[Address(RVA = "0x1E8BA60", Offset = "0x1E8BB61", VA = "0x1E8BA60", Slot = "63")]
	public virtual void SetNavMeshAgentEnable(bool enable)
	{
	}

	// Token: 0x06000BCC RID: 3020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7C")]
	[Address(RVA = "0x1E8BB20", Offset = "0x1E8BC21", VA = "0x1E8BB20")]
	public void SetInvincible(float time)
	{
	}

	// Token: 0x06000BCD RID: 3021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7D")]
	[Address(RVA = "0x1E8BBB0", Offset = "0x1E8BCB1", VA = "0x1E8BBB0")]
	public void UpdateInCageWeb()
	{
	}

	// Token: 0x06000BCE RID: 3022 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7E")]
	[Address(RVA = "0x1E8BC10", Offset = "0x1E8BD11", VA = "0x1E8BC10")]
	public void EndInCageWeb()
	{
	}

	// Token: 0x06000BCF RID: 3023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7F")]
	[Address(RVA = "0x1E87820", Offset = "0x1E87921", VA = "0x1E87820")]
	private void UpdateInvincible(float deltaTime)
	{
	}

	// Token: 0x06000BD0 RID: 3024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A80")]
	[Address(RVA = "0x1E8BC80", Offset = "0x1E8BD81", VA = "0x1E8BC80", Slot = "17")]
	public override void OnSwitchActorBase(bool on)
	{
	}

	// Token: 0x06000BD1 RID: 3025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A81")]
	[Address(RVA = "0x1E8BE70", Offset = "0x1E8BF71", VA = "0x1E8BE70", Slot = "64")]
	public virtual void OnBadStatus(BadStatus badStatus, bool isEnable)
	{
	}

	// Token: 0x06000BD2 RID: 3026 RVA: 0x00005B98 File Offset: 0x00003D98
	[Token(Token = "0x6000A82")]
	[Address(RVA = "0x1E8BE80", Offset = "0x1E8BF81", VA = "0x1E8BE80", Slot = "65")]
	public virtual bool OnBeforeDamageAction(DamageActionType type, DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06000BD3 RID: 3027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A83")]
	[Address(RVA = "0x1E8BE90", Offset = "0x1E8BF91", VA = "0x1E8BE90", Slot = "66")]
	public virtual void OnPlayDamageAction(DamageActionType type, DamageResult damageResult)
	{
	}

	// Token: 0x06000BD4 RID: 3028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A84")]
	[Address(RVA = "0x1E8BEA0", Offset = "0x1E8BFA1", VA = "0x1E8BEA0", Slot = "67")]
	public virtual void OnStopDamageAction(DamageActionType type, DamageResult damageResult)
	{
	}

	// Token: 0x06000BD5 RID: 3029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A85")]
	[Address(RVA = "0x1E8BEB0", Offset = "0x1E8BFB1", VA = "0x1E8BEB0", Slot = "68")]
	public virtual void OnAfterDamageAction(DamageActionType type, DamageResult damageResult)
	{
	}

	// Token: 0x06000BD6 RID: 3030 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A86")]
	[Address(RVA = "0x1E8BEC0", Offset = "0x1E8BFC1", VA = "0x1E8BEC0", Slot = "69")]
	public virtual void AddDamagedPost(DamageInfo damageInfo, DamageResult result)
	{
	}

	// Token: 0x06000BD7 RID: 3031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A87")]
	[Address(RVA = "0x1E8BED0", Offset = "0x1E8BFD1", VA = "0x1E8BED0", Slot = "70")]
	public virtual void OnLanding()
	{
	}

	// Token: 0x06000BD8 RID: 3032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A88")]
	[Address(RVA = "0x1E8BF90", Offset = "0x1E8C091", VA = "0x1E8BF90", Slot = "71")]
	public virtual void OnFalling()
	{
	}

	// Token: 0x06000BD9 RID: 3033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A89")]
	[Address(RVA = "0x1E8BFA0", Offset = "0x1E8C0A1", VA = "0x1E8BFA0", Slot = "72")]
	public virtual void OnSliding()
	{
	}

	// Token: 0x06000BDA RID: 3034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A8A")]
	[Address(RVA = "0x1E8BFB0", Offset = "0x1E8C0B1", VA = "0x1E8BFB0")]
	public Character()
	{
	}

	// Token: 0x040006E1 RID: 1761
	[Token(Token = "0x4000586")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x15D4C0", Offset = "0x15D5C1")]
	[SerializeField]
	protected UnityEvent[] m_ActionEvents;

	// Token: 0x040006E2 RID: 1762
	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static readonly float DefaultHumanScale;

	// Token: 0x040006E3 RID: 1763
	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	protected static readonly Vector3 LOCKON_OFFSET;

	// Token: 0x040006E4 RID: 1764
	[Token(Token = "0x4000589")]
	private const float APPROACH_MAX_RANGE = 6f;

	// Token: 0x040006E5 RID: 1765
	[Token(Token = "0x400058A")]
	private const float BOSSBATTLE_LOCKON_RANGE = 1000f;

	// Token: 0x040006E6 RID: 1766
	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D510", Offset = "0x15D611")]
	private readonly CharacterStatusBase <Status>k__BackingField;

	// Token: 0x040006E7 RID: 1767
	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D520", Offset = "0x15D621")]
	private float <InvincibleTimer>k__BackingField;

	// Token: 0x040006E8 RID: 1768
	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D530", Offset = "0x15D631")]
	private bool <IsShortPlayMove>k__BackingField;

	// Token: 0x040006E9 RID: 1769
	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D540", Offset = "0x15D641")]
	private Vector3 <ShortPlayTargetPosition>k__BackingField;

	// Token: 0x040006EA RID: 1770
	[Token(Token = "0x400058F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D550", Offset = "0x15D651")]
	private CharacterBase <LockedTarget>k__BackingField;

	// Token: 0x040006EB RID: 1771
	[Token(Token = "0x4000590")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D560", Offset = "0x15D661")]
	private CharacterAnimationParam <AnimationParam>k__BackingField;

	// Token: 0x040006EC RID: 1772
	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D570", Offset = "0x15D671")]
	private float <Locomotion>k__BackingField;

	// Token: 0x040006ED RID: 1773
	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D580", Offset = "0x15D681")]
	private readonly bool <IsBattleMode>k__BackingField;

	// Token: 0x040006EE RID: 1774
	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D590", Offset = "0x15D691")]
	private NavMeshAgent <NavMeshAgent>k__BackingField;

	// Token: 0x040006EF RID: 1775
	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D5A0", Offset = "0x15D6A1")]
	private CharacterController <CharacterController>k__BackingField;

	// Token: 0x040006F0 RID: 1776
	[Token(Token = "0x4000595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D5B0", Offset = "0x15D6B1")]
	private ActionScriptControllerBase <ActionScriptControllerBase>k__BackingField;

	// Token: 0x040006F1 RID: 1777
	[Token(Token = "0x4000596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D5C0", Offset = "0x15D6C1")]
	private Vector3 <DeltaPosition>k__BackingField;

	// Token: 0x040006F2 RID: 1778
	[Token(Token = "0x4000597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D5D0", Offset = "0x15D6D1")]
	private Quaternion <DeltRotation>k__BackingField;

	// Token: 0x040006F3 RID: 1779
	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D5E0", Offset = "0x15D6E1")]
	private bool <InFarm>k__BackingField;

	// Token: 0x040006F4 RID: 1780
	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D5F0", Offset = "0x15D6F1")]
	private int <InDoorCnt>k__BackingField;

	// Token: 0x040006F5 RID: 1781
	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D600", Offset = "0x15D701")]
	private bool <IsFreeseXZRootMotion>k__BackingField;

	// Token: 0x040006F6 RID: 1782
	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D610", Offset = "0x15D711")]
	private Transform <EffectPoint>k__BackingField;

	// Token: 0x040006F7 RID: 1783
	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x15D620", Offset = "0x15D721")]
	[SerializeField]
	protected CharacterMovement m_Movement;

	// Token: 0x040006F8 RID: 1784
	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[SerializeField]
	protected DamageActionController m_DamageAction;

	// Token: 0x040006F9 RID: 1785
	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	protected ActorVoiceController m_VoiceController;

	// Token: 0x040006FA RID: 1786
	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[SerializeField]
	protected RestraintController m_RestraintController;

	// Token: 0x040006FB RID: 1787
	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[SerializeField]
	protected SlowStateController m_SlowStateController;

	// Token: 0x040006FC RID: 1788
	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[SerializeField]
	protected FootSteps m_FootSteps;

	// Token: 0x040006FD RID: 1789
	[Token(Token = "0x40005A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[SerializeField]
	protected CharaFaceController m_FaceController;

	// Token: 0x040006FE RID: 1790
	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[SerializeField]
	protected PersonalMotionController m_PersonalMotion;

	// Token: 0x040006FF RID: 1791
	[Token(Token = "0x40005A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[SerializeField]
	protected MagicMotionController m_MagicMotionController;

	// Token: 0x04000700 RID: 1792
	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[SerializeField]
	protected EscapeController m_EscapeController;

	// Token: 0x04000701 RID: 1793
	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[SerializeField]
	protected RideController m_RideController;

	// Token: 0x04000702 RID: 1794
	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[SerializeField]
	protected LazyController m_LazyController;

	// Token: 0x04000703 RID: 1795
	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	[SerializeField]
	protected SuperArmorController m_SuperArmor;

	// Token: 0x04000704 RID: 1796
	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x15D730", Offset = "0x15D831")]
	[SerializeField]
	protected float m_LockonRadius;

	// Token: 0x04000705 RID: 1797
	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	[SerializeField]
	protected float m_LockonAngle;

	// Token: 0x04000706 RID: 1798
	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	protected float m_ApproachEnemyRadius;

	// Token: 0x04000707 RID: 1799
	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	protected float m_ApproachEnemyAngle;

	// Token: 0x04000708 RID: 1800
	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private bool _IsShortPlay;

	// Token: 0x04000709 RID: 1801
	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Dictionary<string, int> m_HashParam;

	// Token: 0x0400070A RID: 1802
	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	protected float FreeseXZRootMotionTimer;

	// Token: 0x02000219 RID: 537
	[Token(Token = "0x2000FED")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157240", Offset = "0x157341")]
	private sealed class <>c__DisplayClass191_0
	{
		// Token: 0x06000BDC RID: 3036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C3B")]
		[Address(RVA = "0x1E8C180", Offset = "0x1E8C281", VA = "0x1E8C180")]
		public <>c__DisplayClass191_0()
		{
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[Token(Token = "0x6006C3C")]
		[Address(RVA = "0x1E8C190", Offset = "0x1E8C291", VA = "0x1E8C190")]
		internal bool <GetAnimatorParamHash>b__0(AnimatorControllerParameter x)
		{
			return default(bool);
		}

		// Token: 0x0400070B RID: 1803
		[Token(Token = "0x4018DCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;
	}
}
