using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B31 RID: 2865
[Token(Token = "0x200077B")]
public class EmotionController : MonoBehaviour
{
	// Token: 0x170009CC RID: 2508
	// (get) Token: 0x060049EA RID: 18922 RVA: 0x00017C70 File Offset: 0x00015E70
	// (set) Token: 0x060049EB RID: 18923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007CE")]
	public EmotionType CurrentEmotionType
	{
		[Token(Token = "0x6003DDC")]
		[Address(RVA = "0x22AF3B0", Offset = "0x22AF4B1", VA = "0x22AF3B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8B10", Offset = "0x1A8C11")]
		get
		{
			return EmotionType.None;
		}
		[Token(Token = "0x6003DDD")]
		[Address(RVA = "0x22AF3C0", Offset = "0x22AF4C1", VA = "0x22AF3C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8B20", Offset = "0x1A8C21")]
		protected set
		{
		}
	}

	// Token: 0x170009CD RID: 2509
	// (get) Token: 0x060049EC RID: 18924 RVA: 0x00017C88 File Offset: 0x00015E88
	[Token(Token = "0x170007CF")]
	public bool IsPlaying
	{
		[Token(Token = "0x6003DDE")]
		[Address(RVA = "0x22AF3D0", Offset = "0x22AF4D1", VA = "0x22AF3D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170009CE RID: 2510
	// (get) Token: 0x060049ED RID: 18925 RVA: 0x00017CA0 File Offset: 0x00015EA0
	// (set) Token: 0x060049EE RID: 18926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007D0")]
	public float Elapsed
	{
		[Token(Token = "0x6003DDF")]
		[Address(RVA = "0x22AF3E0", Offset = "0x22AF4E1", VA = "0x22AF3E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8B30", Offset = "0x1A8C31")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6003DE0")]
		[Address(RVA = "0x22AF3F0", Offset = "0x22AF4F1", VA = "0x22AF3F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8B40", Offset = "0x1A8C41")]
		protected set
		{
		}
	}

	// Token: 0x060049EF RID: 18927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DE1")]
	[Address(RVA = "0x22AF400", Offset = "0x22AF501", VA = "0x22AF400", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x060049F0 RID: 18928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DE2")]
	[Address(RVA = "0x22AF440", Offset = "0x22AF541", VA = "0x22AF440", Slot = "5")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x060049F1 RID: 18929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DE3")]
	[Address(RVA = "0x22AF5B0", Offset = "0x22AF6B1", VA = "0x22AF5B0", Slot = "6")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x060049F2 RID: 18930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DE4")]
	[Address(RVA = "0x22AF730", Offset = "0x22AF831", VA = "0x22AF730", Slot = "7")]
	public virtual void OnUpdate()
	{
	}

	// Token: 0x060049F3 RID: 18931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DE5")]
	[Address(RVA = "0x22AF860", Offset = "0x22AF961", VA = "0x22AF860", Slot = "8")]
	public virtual void Init(Transform point)
	{
	}

	// Token: 0x060049F4 RID: 18932 RVA: 0x00017CB8 File Offset: 0x00015EB8
	[Token(Token = "0x6003DE6")]
	[Address(RVA = "0x22AF870", Offset = "0x22AF971", VA = "0x22AF870", Slot = "9")]
	public virtual bool DoPlay(EmotionType emotionType, Vector3 offset, [Optional] Action onStop)
	{
		return default(bool);
	}

	// Token: 0x060049F5 RID: 18933 RVA: 0x00017CD0 File Offset: 0x00015ED0
	[Token(Token = "0x6003DE7")]
	[Address(RVA = "0x22AFDD0", Offset = "0x22AFED1", VA = "0x22AFDD0")]
	public bool DoPlay(EmotionType emotionType, [Optional] Action onStop)
	{
		return default(bool);
	}

	// Token: 0x060049F6 RID: 18934 RVA: 0x00017CE8 File Offset: 0x00015EE8
	[Token(Token = "0x6003DE8")]
	[Address(RVA = "0x22AFE60", Offset = "0x22AFF61", VA = "0x22AFE60", Slot = "10")]
	public virtual bool DoStop()
	{
		return default(bool);
	}

	// Token: 0x060049F7 RID: 18935 RVA: 0x00017D00 File Offset: 0x00015F00
	[Token(Token = "0x6003DE9")]
	[Address(RVA = "0x22AFF50", Offset = "0x22B0051", VA = "0x22AFF50", Slot = "11")]
	public virtual bool DoDelete()
	{
		return default(bool);
	}

	// Token: 0x060049F8 RID: 18936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DEA")]
	[Address(RVA = "0x22B0120", Offset = "0x22B0221", VA = "0x22B0120")]
	public EmotionController()
	{
	}

	// Token: 0x0400AA1D RID: 43549
	[Token(Token = "0x4008043")]
	protected const float DefaultPlayDuration = 1f;

	// Token: 0x0400AA1E RID: 43550
	[Token(Token = "0x4008044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<EmotionType, float> m_DurationList;

	// Token: 0x0400AA1F RID: 43551
	[Token(Token = "0x4008045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected Transform m_effectParent;

	// Token: 0x0400AA20 RID: 43552
	[Token(Token = "0x4008046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected EmotionEffectController m_effect;

	// Token: 0x0400AA21 RID: 43553
	[Token(Token = "0x4008047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected Action m_onStop;

	// Token: 0x0400AA22 RID: 43554
	[Token(Token = "0x4008048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected float m_Duration;

	// Token: 0x0400AA23 RID: 43555
	[Token(Token = "0x4008049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1747F0", Offset = "0x1748F1")]
	private EmotionType <CurrentEmotionType>k__BackingField;

	// Token: 0x0400AA24 RID: 43556
	[Token(Token = "0x400804A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x174800", Offset = "0x174901")]
	private float <Elapsed>k__BackingField;
}
