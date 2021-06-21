using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200040A RID: 1034
[Token(Token = "0x2000328")]
public class ParticleDestroy : MonoBehaviour
{
	// Token: 0x17000424 RID: 1060
	// (get) Token: 0x060017D2 RID: 6098 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060017D3 RID: 6099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003BA")]
	private ParticleSystem[] ParticleSystems
	{
		[Token(Token = "0x600152F")]
		[Address(RVA = "0x231B290", Offset = "0x231B391", VA = "0x231B290")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D540", Offset = "0x19D641")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001530")]
		[Address(RVA = "0x231B2A0", Offset = "0x231B3A1", VA = "0x231B2A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D550", Offset = "0x19D651")]
		set
		{
		}
	}

	// Token: 0x17000425 RID: 1061
	// (get) Token: 0x060017D4 RID: 6100 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060017D5 RID: 6101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003BB")]
	private Transform Target
	{
		[Token(Token = "0x6001531")]
		[Address(RVA = "0x231B2B0", Offset = "0x231B3B1", VA = "0x231B2B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D560", Offset = "0x19D661")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001532")]
		[Address(RVA = "0x231B2C0", Offset = "0x231B3C1", VA = "0x231B2C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D570", Offset = "0x19D671")]
		set
		{
		}
	}

	// Token: 0x17000426 RID: 1062
	// (get) Token: 0x060017D6 RID: 6102 RVA: 0x0000A518 File Offset: 0x00008718
	// (set) Token: 0x060017D7 RID: 6103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003BC")]
	private bool IsTargetMode
	{
		[Token(Token = "0x6001533")]
		[Address(RVA = "0x231B2D0", Offset = "0x231B3D1", VA = "0x231B2D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D580", Offset = "0x19D681")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001534")]
		[Address(RVA = "0x231B2E0", Offset = "0x231B3E1", VA = "0x231B2E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D590", Offset = "0x19D691")]
		set
		{
		}
	}

	// Token: 0x17000427 RID: 1063
	// (get) Token: 0x060017D8 RID: 6104 RVA: 0x0000A530 File Offset: 0x00008730
	// (set) Token: 0x060017D9 RID: 6105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003BD")]
	private ParticleDestroy.State m_State
	{
		[Token(Token = "0x6001535")]
		[Address(RVA = "0x231B2F0", Offset = "0x231B3F1", VA = "0x231B2F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D5A0", Offset = "0x19D6A1")]
		get
		{
			return ParticleDestroy.State.WaitPlay;
		}
		[Token(Token = "0x6001536")]
		[Address(RVA = "0x231B300", Offset = "0x231B401", VA = "0x231B300")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D5B0", Offset = "0x19D6B1")]
		set
		{
		}
	}

	// Token: 0x17000428 RID: 1064
	// (get) Token: 0x060017DA RID: 6106 RVA: 0x0000A548 File Offset: 0x00008748
	// (set) Token: 0x060017DB RID: 6107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003BE")]
	public float MaxLifeTime
	{
		[Token(Token = "0x6001537")]
		[Address(RVA = "0x231B310", Offset = "0x231B411", VA = "0x231B310")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D5C0", Offset = "0x19D6C1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001538")]
		[Address(RVA = "0x231B320", Offset = "0x231B421", VA = "0x231B320")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D5D0", Offset = "0x19D6D1")]
		private set
		{
		}
	}

	// Token: 0x17000429 RID: 1065
	// (get) Token: 0x060017DC RID: 6108 RVA: 0x0000A560 File Offset: 0x00008760
	// (set) Token: 0x060017DD RID: 6109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003BF")]
	public float MaxDuration
	{
		[Token(Token = "0x6001539")]
		[Address(RVA = "0x231B330", Offset = "0x231B431", VA = "0x231B330")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D5E0", Offset = "0x19D6E1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600153A")]
		[Address(RVA = "0x231B340", Offset = "0x231B441", VA = "0x231B340")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D5F0", Offset = "0x19D6F1")]
		set
		{
		}
	}

	// Token: 0x1700042A RID: 1066
	// (get) Token: 0x060017DE RID: 6110 RVA: 0x0000A578 File Offset: 0x00008778
	// (set) Token: 0x060017DF RID: 6111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003C0")]
	public bool IsLoopMode
	{
		[Token(Token = "0x600153B")]
		[Address(RVA = "0x231B350", Offset = "0x231B451", VA = "0x231B350")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D600", Offset = "0x19D701")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600153C")]
		[Address(RVA = "0x231B360", Offset = "0x231B461", VA = "0x231B360")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D610", Offset = "0x19D711")]
		set
		{
		}
	}

	// Token: 0x1700042B RID: 1067
	// (get) Token: 0x060017E0 RID: 6112 RVA: 0x0000A590 File Offset: 0x00008790
	// (set) Token: 0x060017E1 RID: 6113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003C1")]
	public Vector3 OffsetPos
	{
		[Token(Token = "0x600153D")]
		[Address(RVA = "0x231B370", Offset = "0x231B471", VA = "0x231B370")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D620", Offset = "0x19D721")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600153E")]
		[Address(RVA = "0x231B380", Offset = "0x231B481", VA = "0x231B380")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D630", Offset = "0x19D731")]
		set
		{
		}
	}

	// Token: 0x1700042C RID: 1068
	// (get) Token: 0x060017E2 RID: 6114 RVA: 0x0000A5A8 File Offset: 0x000087A8
	// (set) Token: 0x060017E3 RID: 6115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003C2")]
	public Quaternion OffsetRote
	{
		[Token(Token = "0x600153F")]
		[Address(RVA = "0x231B390", Offset = "0x231B491", VA = "0x231B390")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D640", Offset = "0x19D741")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6001540")]
		[Address(RVA = "0x231B3A0", Offset = "0x231B4A1", VA = "0x231B3A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D650", Offset = "0x19D751")]
		set
		{
		}
	}

	// Token: 0x1700042D RID: 1069
	// (get) Token: 0x060017E4 RID: 6116 RVA: 0x0000A5C0 File Offset: 0x000087C0
	// (set) Token: 0x060017E5 RID: 6117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003C3")]
	public Vector3 OffsetScale
	{
		[Token(Token = "0x6001541")]
		[Address(RVA = "0x231B3C0", Offset = "0x231B4C1", VA = "0x231B3C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D660", Offset = "0x19D761")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001542")]
		[Address(RVA = "0x231B3D0", Offset = "0x231B4D1", VA = "0x231B3D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D670", Offset = "0x19D771")]
		set
		{
		}
	}

	// Token: 0x1700042E RID: 1070
	// (get) Token: 0x060017E6 RID: 6118 RVA: 0x0000A5D8 File Offset: 0x000087D8
	// (set) Token: 0x060017E7 RID: 6119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003C4")]
	private Vector3 Velocity
	{
		[Token(Token = "0x6001543")]
		[Address(RVA = "0x231B3E0", Offset = "0x231B4E1", VA = "0x231B3E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D680", Offset = "0x19D781")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001544")]
		[Address(RVA = "0x231B3F0", Offset = "0x231B4F1", VA = "0x231B3F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D690", Offset = "0x19D791")]
		set
		{
		}
	}

	// Token: 0x1700042F RID: 1071
	// (get) Token: 0x060017E8 RID: 6120 RVA: 0x0000A5F0 File Offset: 0x000087F0
	// (set) Token: 0x060017E9 RID: 6121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003C5")]
	private Vector3 PrevPos
	{
		[Token(Token = "0x6001545")]
		[Address(RVA = "0x231B400", Offset = "0x231B501", VA = "0x231B400")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D6A0", Offset = "0x19D7A1")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001546")]
		[Address(RVA = "0x231B410", Offset = "0x231B511", VA = "0x231B410")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D6B0", Offset = "0x19D7B1")]
		set
		{
		}
	}

	// Token: 0x060017EA RID: 6122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001547")]
	[Address(RVA = "0x231B420", Offset = "0x231B521", VA = "0x231B420")]
	public void SetParentTransform(Transform transform)
	{
	}

	// Token: 0x060017EB RID: 6123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001548")]
	[Address(RVA = "0x231B800", Offset = "0x231B901", VA = "0x231B800")]
	public void Destroy()
	{
	}

	// Token: 0x060017EC RID: 6124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001549")]
	[Address(RVA = "0x231B870", Offset = "0x231B971", VA = "0x231B870")]
	private void OnDisable()
	{
	}

	// Token: 0x060017ED RID: 6125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600154A")]
	[Address(RVA = "0x231B890", Offset = "0x231B991", VA = "0x231B890")]
	private void Awake()
	{
	}

	// Token: 0x060017EE RID: 6126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600154B")]
	[Address(RVA = "0x231B8F0", Offset = "0x231B9F1", VA = "0x231B8F0")]
	private void Start()
	{
	}

	// Token: 0x060017EF RID: 6127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600154C")]
	[Address(RVA = "0x231BC70", Offset = "0x231BD71", VA = "0x231BC70")]
	private void WaitPlay_Enter()
	{
	}

	// Token: 0x060017F0 RID: 6128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600154D")]
	[Address(RVA = "0x231BC80", Offset = "0x231BD81", VA = "0x231BC80")]
	private void WaitPlay_Update()
	{
	}

	// Token: 0x060017F1 RID: 6129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600154E")]
	[Address(RVA = "0x231BD10", Offset = "0x231BE11", VA = "0x231BD10")]
	private void WaitPlay_LateUpdate()
	{
	}

	// Token: 0x060017F2 RID: 6130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600154F")]
	[Address(RVA = "0x231BD20", Offset = "0x231BE21", VA = "0x231BD20")]
	private void LoopPlay_Enter()
	{
	}

	// Token: 0x060017F3 RID: 6131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001550")]
	[Address(RVA = "0x231BD30", Offset = "0x231BE31", VA = "0x231BD30")]
	private void LoopPlay_Update()
	{
	}

	// Token: 0x060017F4 RID: 6132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001551")]
	[Address(RVA = "0x231BE00", Offset = "0x231BF01", VA = "0x231BE00")]
	private void LoopPlay_LateUpdate()
	{
	}

	// Token: 0x060017F5 RID: 6133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001552")]
	[Address(RVA = "0x231BE10", Offset = "0x231BF11", VA = "0x231BE10")]
	private void Playing_Enter()
	{
	}

	// Token: 0x060017F6 RID: 6134 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001553")]
	[Address(RVA = "0x231BE20", Offset = "0x231BF21", VA = "0x231BE20")]
	private void Playing_Update()
	{
	}

	// Token: 0x060017F7 RID: 6135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001554")]
	[Address(RVA = "0x231BF00", Offset = "0x231C001", VA = "0x231BF00")]
	private void Playing_LateUpdate()
	{
	}

	// Token: 0x060017F8 RID: 6136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001555")]
	[Address(RVA = "0x231BF10", Offset = "0x231C011", VA = "0x231BF10")]
	private void WaitDestroy_Enter()
	{
	}

	// Token: 0x060017F9 RID: 6137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001556")]
	[Address(RVA = "0x231BFA0", Offset = "0x231C0A1", VA = "0x231BFA0")]
	private void WaitDestroy_Update()
	{
	}

	// Token: 0x060017FA RID: 6138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001557")]
	[Address(RVA = "0x231C040", Offset = "0x231C141", VA = "0x231C040")]
	private void WaitDestroy_LateUpdate()
	{
	}

	// Token: 0x060017FB RID: 6139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001558")]
	[Address(RVA = "0x231B4D0", Offset = "0x231B5D1", VA = "0x231B4D0")]
	private void UpdateTransform()
	{
	}

	// Token: 0x060017FC RID: 6140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001559")]
	[Address(RVA = "0x231C0E0", Offset = "0x231C1E1", VA = "0x231C0E0")]
	private void UpdateTransformLocal(float deltaTime)
	{
	}

	// Token: 0x060017FD RID: 6141 RVA: 0x0000A608 File Offset: 0x00008808
	[Token(Token = "0x600155A")]
	[Address(RVA = "0x231B820", Offset = "0x231B921", VA = "0x231B820")]
	private bool ChangeState(ParticleDestroy.State state)
	{
		return default(bool);
	}

	// Token: 0x060017FE RID: 6142 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600155B")]
	[Address(RVA = "0x231C210", Offset = "0x231C311", VA = "0x231C210")]
	private void StateUpdate()
	{
	}

	// Token: 0x060017FF RID: 6143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600155C")]
	[Address(RVA = "0x231C380", Offset = "0x231C481", VA = "0x231C380")]
	private void StateLateUpdate()
	{
	}

	// Token: 0x06001800 RID: 6144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600155D")]
	[Address(RVA = "0x231C410", Offset = "0x231C511", VA = "0x231C410")]
	private void Update()
	{
	}

	// Token: 0x06001801 RID: 6145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600155E")]
	[Address(RVA = "0x231C4A0", Offset = "0x231C5A1", VA = "0x231C4A0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001802 RID: 6146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600155F")]
	[Address(RVA = "0x231C580", Offset = "0x231C681", VA = "0x231C580")]
	private void Reset()
	{
	}

	// Token: 0x06001803 RID: 6147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001560")]
	[Address(RVA = "0x231C5C0", Offset = "0x231C6C1", VA = "0x231C5C0")]
	public ParticleDestroy()
	{
	}

	// Token: 0x04005BD9 RID: 23513
	[Token(Token = "0x4005865")]
	[FieldOffset(Offset = "0x18")]
	private float m_Elapsed;

	// Token: 0x04005BDA RID: 23514
	[Token(Token = "0x4005866")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1627E0", Offset = "0x1628E1")]
	private ParticleSystem[] <ParticleSystems>k__BackingField;

	// Token: 0x04005BDB RID: 23515
	[Token(Token = "0x4005867")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1627F0", Offset = "0x1628F1")]
	private Transform <Target>k__BackingField;

	// Token: 0x04005BDC RID: 23516
	[Token(Token = "0x4005868")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x162800", Offset = "0x162901")]
	private bool <IsTargetMode>k__BackingField;

	// Token: 0x04005BDD RID: 23517
	[Token(Token = "0x4005869")]
	[FieldOffset(Offset = "0x31")]
	[SerializeField]
	private bool IsPrefabAttach;

	// Token: 0x04005BDE RID: 23518
	[Token(Token = "0x400586A")]
	[FieldOffset(Offset = "0x32")]
	[SerializeField]
	public bool IsAutoVelocity;

	// Token: 0x04005BDF RID: 23519
	[Token(Token = "0x400586B")]
	[FieldOffset(Offset = "0x33")]
	[SerializeField]
	private bool IsUseScale;

	// Token: 0x04005BE0 RID: 23520
	[Token(Token = "0x400586C")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x162840", Offset = "0x162941")]
	private ParticleDestroy.State <m_State>k__BackingField;

	// Token: 0x04005BE1 RID: 23521
	[Token(Token = "0x400586D")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x162850", Offset = "0x162951")]
	private float <MaxLifeTime>k__BackingField;

	// Token: 0x04005BE2 RID: 23522
	[Token(Token = "0x400586E")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x162860", Offset = "0x162961")]
	private float <MaxDuration>k__BackingField;

	// Token: 0x04005BE3 RID: 23523
	[Token(Token = "0x400586F")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x162870", Offset = "0x162971")]
	private bool <IsLoopMode>k__BackingField;

	// Token: 0x04005BE4 RID: 23524
	[Token(Token = "0x4005870")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x162880", Offset = "0x162981")]
	private Vector3 <OffsetPos>k__BackingField;

	// Token: 0x04005BE5 RID: 23525
	[Token(Token = "0x4005871")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x162890", Offset = "0x162991")]
	private Quaternion <OffsetRote>k__BackingField;

	// Token: 0x04005BE6 RID: 23526
	[Token(Token = "0x4005872")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1628A0", Offset = "0x1629A1")]
	private Vector3 <OffsetScale>k__BackingField;

	// Token: 0x04005BE7 RID: 23527
	[Token(Token = "0x4005873")]
	[FieldOffset(Offset = "0x6C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1628B0", Offset = "0x1629B1")]
	private Vector3 <Velocity>k__BackingField;

	// Token: 0x04005BE8 RID: 23528
	[Token(Token = "0x4005874")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1628C0", Offset = "0x1629C1")]
	private Vector3 <PrevPos>k__BackingField;

	// Token: 0x0200040B RID: 1035
	[Token(Token = "0x200106B")]
	public enum State
	{
		// Token: 0x04005BEA RID: 23530
		[Token(Token = "0x4018FE8")]
		WaitPlay,
		// Token: 0x04005BEB RID: 23531
		[Token(Token = "0x4018FE9")]
		LoopPlay,
		// Token: 0x04005BEC RID: 23532
		[Token(Token = "0x4018FEA")]
		Playing,
		// Token: 0x04005BED RID: 23533
		[Token(Token = "0x4018FEB")]
		WaitDestroy
	}
}
