using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x02000226 RID: 550
[Token(Token = "0x20001BB")]
public class DamageActionController : MonoBehaviour
{
	// Token: 0x17000265 RID: 613
	// (get) Token: 0x06000C88 RID: 3208 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C89 RID: 3209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000245")]
	private Character character
	{
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x1D9F7D0", Offset = "0x1D9F8D1", VA = "0x1D9F7D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B9F0", Offset = "0x19BAF1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x1D9F7E0", Offset = "0x1D9F8E1", VA = "0x1D9F7E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BA00", Offset = "0x19BB01")]
		set
		{
		}
	}

	// Token: 0x17000266 RID: 614
	// (get) Token: 0x06000C8A RID: 3210 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C8B RID: 3211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000246")]
	private CharacterController characterController
	{
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x1D9F7F0", Offset = "0x1D9F8F1", VA = "0x1D9F7F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BA10", Offset = "0x19BB11")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x1D9F800", Offset = "0x1D9F901", VA = "0x1D9F800")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BA20", Offset = "0x19BB21")]
		set
		{
		}
	}

	// Token: 0x17000267 RID: 615
	// (get) Token: 0x06000C8C RID: 3212 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C8D RID: 3213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000247")]
	public NavMeshAgent navMeshAgent
	{
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x1D9F810", Offset = "0x1D9F911", VA = "0x1D9F810")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BA30", Offset = "0x19BB31")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x1D9F820", Offset = "0x1D9F921", VA = "0x1D9F820")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BA40", Offset = "0x19BB41")]
		set
		{
		}
	}

	// Token: 0x17000268 RID: 616
	// (get) Token: 0x06000C8E RID: 3214 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C8F RID: 3215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000248")]
	private CharacterMovement movement
	{
		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x1D9F830", Offset = "0x1D9F931", VA = "0x1D9F830")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BA50", Offset = "0x19BB51")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x1D9F840", Offset = "0x1D9F941", VA = "0x1D9F840")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BA60", Offset = "0x19BB61")]
		set
		{
		}
	}

	// Token: 0x17000269 RID: 617
	// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00006060 File Offset: 0x00004260
	// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000249")]
	public DamageActionType Type
	{
		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x1D9F850", Offset = "0x1D9F951", VA = "0x1D9F850")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BA70", Offset = "0x19BB71")]
		get
		{
			return DamageActionType.None;
		}
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x1D9F860", Offset = "0x1D9F961", VA = "0x1D9F860")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BA80", Offset = "0x19BB81")]
		private set
		{
		}
	}

	// Token: 0x1700026A RID: 618
	// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00006078 File Offset: 0x00004278
	// (set) Token: 0x06000C93 RID: 3219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700024A")]
	public float BlowPower
	{
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x1D9F870", Offset = "0x1D9F971", VA = "0x1D9F870")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BA90", Offset = "0x19BB91")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x1D9F880", Offset = "0x1D9F981", VA = "0x1D9F880")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BAA0", Offset = "0x19BBA1")]
		set
		{
		}
	}

	// Token: 0x1700026B RID: 619
	// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00006090 File Offset: 0x00004290
	[Token(Token = "0x1700024B")]
	public bool IsPlaying
	{
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x1D9F890", Offset = "0x1D9F991", VA = "0x1D9F890")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700026C RID: 620
	// (get) Token: 0x06000C95 RID: 3221 RVA: 0x000060A8 File Offset: 0x000042A8
	// (set) Token: 0x06000C96 RID: 3222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700024C")]
	public bool Locked
	{
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x1D9F8A0", Offset = "0x1D9F9A1", VA = "0x1D9F8A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BAB0", Offset = "0x19BBB1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x1D9F8B0", Offset = "0x1D9F9B1", VA = "0x1D9F8B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BAC0", Offset = "0x19BBC1")]
		set
		{
		}
	}

	// Token: 0x1700026D RID: 621
	// (get) Token: 0x06000C97 RID: 3223 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C98 RID: 3224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700024D")]
	public Func<DamageActionType, DamageResult, bool> OnBefore
	{
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x1D9F8C0", Offset = "0x1D9F9C1", VA = "0x1D9F8C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BAD0", Offset = "0x19BBD1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x1D9F8D0", Offset = "0x1D9F9D1", VA = "0x1D9F8D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BAE0", Offset = "0x19BBE1")]
		set
		{
		}
	}

	// Token: 0x1700026E RID: 622
	// (get) Token: 0x06000C99 RID: 3225 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C9A RID: 3226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700024E")]
	public Action<DamageActionType, DamageResult> OnPlay
	{
		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x1D9F8E0", Offset = "0x1D9F9E1", VA = "0x1D9F8E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BAF0", Offset = "0x19BBF1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x1D9F8F0", Offset = "0x1D9F9F1", VA = "0x1D9F8F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BB00", Offset = "0x19BC01")]
		set
		{
		}
	}

	// Token: 0x1700026F RID: 623
	// (get) Token: 0x06000C9B RID: 3227 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C9C RID: 3228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700024F")]
	public Action<DamageActionType, DamageResult> OnStop
	{
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x1D9F900", Offset = "0x1D9FA01", VA = "0x1D9F900")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BB10", Offset = "0x19BC11")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x1D9F910", Offset = "0x1D9FA11", VA = "0x1D9F910")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BB20", Offset = "0x19BC21")]
		set
		{
		}
	}

	// Token: 0x17000270 RID: 624
	// (get) Token: 0x06000C9D RID: 3229 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000C9E RID: 3230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000250")]
	public Action<DamageActionType, DamageResult> OnAfter
	{
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x1D9F920", Offset = "0x1D9FA21", VA = "0x1D9F920")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BB30", Offset = "0x19BC31")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x1D9F930", Offset = "0x1D9FA31", VA = "0x1D9F930")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BB40", Offset = "0x19BC41")]
		set
		{
		}
	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B43")]
	[Address(RVA = "0x1D9F940", Offset = "0x1D9FA41", VA = "0x1D9F940")]
	private void Awake()
	{
	}

	// Token: 0x06000CA0 RID: 3232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B44")]
	[Address(RVA = "0x1D9FA10", Offset = "0x1D9FB11", VA = "0x1D9FA10")]
	public void Clear()
	{
	}

	// Token: 0x06000CA1 RID: 3233 RVA: 0x000060C0 File Offset: 0x000042C0
	[Token(Token = "0x6000B45")]
	[Address(RVA = "0x1D9FA20", Offset = "0x1D9FB21", VA = "0x1D9FA20")]
	public bool Play(DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06000CA2 RID: 3234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B46")]
	[Address(RVA = "0x1DA0580", Offset = "0x1DA0681", VA = "0x1DA0580")]
	public void Cancel()
	{
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x000060D8 File Offset: 0x000042D8
	[Token(Token = "0x6000B47")]
	[Address(RVA = "0x1DA0280", Offset = "0x1DA0381", VA = "0x1DA0280")]
	public bool DoAction(DamageActionType type, DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B48")]
	[Address(RVA = "0x1DA0590", Offset = "0x1DA0691", VA = "0x1DA0590")]
	public void StartKnockDown(float duration)
	{
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B49")]
	[Address(RVA = "0x1DA0640", Offset = "0x1DA0741", VA = "0x1DA0640")]
	public void StartKnockBack(Vector3 direction, float power, float duration)
	{
	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4A")]
	[Address(RVA = "0x1DA0050", Offset = "0x1DA0151", VA = "0x1DA0050")]
	public void StartBlow(Vector3 direction, float power)
	{
	}

	// Token: 0x06000CA7 RID: 3239 RVA: 0x000060F0 File Offset: 0x000042F0
	[Token(Token = "0x6000B4B")]
	[Address(RVA = "0x1DA0770", Offset = "0x1DA0871", VA = "0x1DA0770")]
	public bool Apply(float deltaTime)
	{
		return default(bool);
	}

	// Token: 0x06000CA8 RID: 3240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4C")]
	[Address(RVA = "0x1DA1000", Offset = "0x1DA1101", VA = "0x1DA1000")]
	private void OnEnd(DamageActionType damageActionType)
	{
	}

	// Token: 0x06000CA9 RID: 3241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4D")]
	[Address(RVA = "0x1DA0970", Offset = "0x1DA0A71", VA = "0x1DA0970")]
	private void ApplyKnockdown(float deltaTime)
	{
	}

	// Token: 0x06000CAA RID: 3242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4E")]
	[Address(RVA = "0x1DA0A60", Offset = "0x1DA0B61", VA = "0x1DA0A60")]
	private void ApplyKnockback(float deltaTime)
	{
	}

	// Token: 0x06000CAB RID: 3243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4F")]
	[Address(RVA = "0x1DA0CB0", Offset = "0x1DA0DB1", VA = "0x1DA0CB0")]
	private void ApplyBlow(float deltaTime)
	{
	}

	// Token: 0x06000CAC RID: 3244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B50")]
	[Address(RVA = "0x1DA10E0", Offset = "0x1DA11E1", VA = "0x1DA10E0")]
	private void OnStopBlow()
	{
	}

	// Token: 0x06000CAD RID: 3245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B51")]
	[Address(RVA = "0x1DA0CE0", Offset = "0x1DA0DE1", VA = "0x1DA0CE0")]
	private void ApplyDead()
	{
	}

	// Token: 0x06000CAE RID: 3246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B52")]
	[Address(RVA = "0x1DA0DF0", Offset = "0x1DA0EF1", VA = "0x1DA0DF0")]
	private void ApplySleep()
	{
	}

	// Token: 0x06000CAF RID: 3247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B53")]
	[Address(RVA = "0x1DA0F00", Offset = "0x1DA1001", VA = "0x1DA0F00")]
	private void ApplyStun()
	{
	}

	// Token: 0x06000CB0 RID: 3248 RVA: 0x00006108 File Offset: 0x00004308
	[Token(Token = "0x6000B54")]
	[Address(RVA = "0x1DA1250", Offset = "0x1DA1351", VA = "0x1DA1250")]
	public bool OnLanding()
	{
		return default(bool);
	}

	// Token: 0x06000CB1 RID: 3249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B55")]
	[Address(RVA = "0x1DA1260", Offset = "0x1DA1361", VA = "0x1DA1260")]
	public DamageActionController()
	{
	}

	// Token: 0x04000772 RID: 1906
	[Token(Token = "0x4000608")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DB70", Offset = "0x15DC71")]
	private Character <character>k__BackingField;

	// Token: 0x04000773 RID: 1907
	[Token(Token = "0x4000609")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DB80", Offset = "0x15DC81")]
	private CharacterController <characterController>k__BackingField;

	// Token: 0x04000774 RID: 1908
	[Token(Token = "0x400060A")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DB90", Offset = "0x15DC91")]
	private NavMeshAgent <navMeshAgent>k__BackingField;

	// Token: 0x04000775 RID: 1909
	[Token(Token = "0x400060B")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DBA0", Offset = "0x15DCA1")]
	private CharacterMovement <movement>k__BackingField;

	// Token: 0x04000776 RID: 1910
	[Token(Token = "0x400060C")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 m_Force;

	// Token: 0x04000777 RID: 1911
	[Token(Token = "0x400060D")]
	[FieldOffset(Offset = "0x44")]
	private float m_Duration;

	// Token: 0x04000778 RID: 1912
	[Token(Token = "0x400060E")]
	[FieldOffset(Offset = "0x48")]
	private float m_Elapsed;

	// Token: 0x04000779 RID: 1913
	[Token(Token = "0x400060F")]
	[FieldOffset(Offset = "0x50")]
	private DamageResult m_currentDamageResult;

	// Token: 0x0400077A RID: 1914
	[Token(Token = "0x4000610")]
	[FieldOffset(Offset = "0x90")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DBB0", Offset = "0x15DCB1")]
	private DamageActionType <Type>k__BackingField;

	// Token: 0x0400077B RID: 1915
	[Token(Token = "0x4000611")]
	[FieldOffset(Offset = "0x94")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DBC0", Offset = "0x15DCC1")]
	private float <BlowPower>k__BackingField;

	// Token: 0x0400077C RID: 1916
	[Token(Token = "0x4000612")]
	[FieldOffset(Offset = "0x98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DBD0", Offset = "0x15DCD1")]
	private bool <Locked>k__BackingField;

	// Token: 0x0400077D RID: 1917
	[Token(Token = "0x4000613")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DBE0", Offset = "0x15DCE1")]
	private Func<DamageActionType, DamageResult, bool> <OnBefore>k__BackingField;

	// Token: 0x0400077E RID: 1918
	[Token(Token = "0x4000614")]
	[FieldOffset(Offset = "0xA8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DBF0", Offset = "0x15DCF1")]
	private Action<DamageActionType, DamageResult> <OnPlay>k__BackingField;

	// Token: 0x0400077F RID: 1919
	[Token(Token = "0x4000615")]
	[FieldOffset(Offset = "0xB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DC00", Offset = "0x15DD01")]
	private Action<DamageActionType, DamageResult> <OnStop>k__BackingField;

	// Token: 0x04000780 RID: 1920
	[Token(Token = "0x4000616")]
	[FieldOffset(Offset = "0xB8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DC10", Offset = "0x15DD11")]
	private Action<DamageActionType, DamageResult> <OnAfter>k__BackingField;
}
