using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

// Token: 0x0200080C RID: 2060
[Token(Token = "0x200054F")]
public class NpcMoveControl : MonoBehaviour
{
	// Token: 0x170007AE RID: 1966
	// (get) Token: 0x0600370A RID: 14090 RVA: 0x00012FF0 File Offset: 0x000111F0
	// (set) Token: 0x0600370B RID: 14091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005F7")]
	[SerializeField]
	public NpcMoveControl.STATE State
	{
		[Token(Token = "0x6002DC4")]
		[Address(RVA = "0x1F50740", Offset = "0x1F50841", VA = "0x1F50740")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5B60", Offset = "0x1A5C61")]
		get
		{
			return NpcMoveControl.STATE.NONE;
		}
		[Token(Token = "0x6002DC5")]
		[Address(RVA = "0x1F50750", Offset = "0x1F50851", VA = "0x1F50750")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5B70", Offset = "0x1A5C71")]
		private set
		{
		}
	}

	// Token: 0x170007AF RID: 1967
	// (get) Token: 0x0600370C RID: 14092 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170005F8")]
	public CharacterMovement Movement
	{
		[Token(Token = "0x6002DC6")]
		[Address(RVA = "0x1F50760", Offset = "0x1F50861", VA = "0x1F50760")]
		get
		{
			return null;
		}
	}

	// Token: 0x170007B0 RID: 1968
	// (get) Token: 0x0600370D RID: 14093 RVA: 0x00013008 File Offset: 0x00011208
	[Token(Token = "0x170005F9")]
	public float SpeedScale
	{
		[Token(Token = "0x6002DC7")]
		[Address(RVA = "0x1F50770", Offset = "0x1F50871", VA = "0x1F50770")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170007B1 RID: 1969
	// (get) Token: 0x0600370E RID: 14094 RVA: 0x00013020 File Offset: 0x00011220
	// (set) Token: 0x0600370F RID: 14095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005FA")]
	public bool IsInDoor
	{
		[Token(Token = "0x6002DC8")]
		[Address(RVA = "0x1F50780", Offset = "0x1F50881", VA = "0x1F50780")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5B80", Offset = "0x1A5C81")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002DC9")]
		[Address(RVA = "0x1F50790", Offset = "0x1F50891", VA = "0x1F50790")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5B90", Offset = "0x1A5C91")]
		private set
		{
		}
	}

	// Token: 0x170007B2 RID: 1970
	// (get) Token: 0x06003710 RID: 14096 RVA: 0x00013038 File Offset: 0x00011238
	// (set) Token: 0x06003711 RID: 14097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005FB")]
	public float speed
	{
		[Token(Token = "0x6002DCA")]
		[Address(RVA = "0x1F507A0", Offset = "0x1F508A1", VA = "0x1F507A0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6002DCB")]
		[Address(RVA = "0x1F507B0", Offset = "0x1F508B1", VA = "0x1F507B0")]
		set
		{
		}
	}

	// Token: 0x170007B3 RID: 1971
	// (get) Token: 0x06003712 RID: 14098 RVA: 0x00013050 File Offset: 0x00011250
	[Token(Token = "0x170005FC")]
	public float remainingDistance
	{
		[Token(Token = "0x6002DCC")]
		[Address(RVA = "0x1F507C0", Offset = "0x1F508C1", VA = "0x1F507C0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170007B4 RID: 1972
	// (get) Token: 0x06003713 RID: 14099 RVA: 0x00013068 File Offset: 0x00011268
	[Token(Token = "0x170005FD")]
	public bool IsReady
	{
		[Token(Token = "0x6002DCD")]
		[Address(RVA = "0x1F50880", Offset = "0x1F50981", VA = "0x1F50880")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170007B5 RID: 1973
	// (get) Token: 0x06003714 RID: 14100 RVA: 0x00013080 File Offset: 0x00011280
	// (set) Token: 0x06003715 RID: 14101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005FE")]
	public bool MoveEnable
	{
		[Token(Token = "0x6002DCE")]
		[Address(RVA = "0x1F50940", Offset = "0x1F50A41", VA = "0x1F50940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002DCF")]
		[Address(RVA = "0x1F4D570", Offset = "0x1F4D671", VA = "0x1F4D570")]
		set
		{
		}
	}

	// Token: 0x06003716 RID: 14102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DD0")]
	[Address(RVA = "0x1F50950", Offset = "0x1F50A51", VA = "0x1F50950")]
	public void StopMove()
	{
	}

	// Token: 0x06003717 RID: 14103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DD1")]
	[Address(RVA = "0x1F50B10", Offset = "0x1F50C11", VA = "0x1F50B10")]
	public void StartMove()
	{
	}

	// Token: 0x06003718 RID: 14104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DD2")]
	[Address(RVA = "0x1F50B90", Offset = "0x1F50C91", VA = "0x1F50B90")]
	public void SetIdle()
	{
	}

	// Token: 0x06003719 RID: 14105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DD3")]
	[Address(RVA = "0x1F50C50", Offset = "0x1F50D51", VA = "0x1F50C50")]
	private void Start()
	{
	}

	// Token: 0x0600371A RID: 14106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DD4")]
	[Address(RVA = "0x1F50E80", Offset = "0x1F50F81", VA = "0x1F50E80")]
	private void Update()
	{
	}

	// Token: 0x0600371B RID: 14107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DD5")]
	[Address(RVA = "0x1F51F20", Offset = "0x1F52021", VA = "0x1F51F20")]
	private void FixedUpdate()
	{
	}

	// Token: 0x0600371C RID: 14108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DD6")]
	[Address(RVA = "0x1F52060", Offset = "0x1F52161", VA = "0x1F52060", Slot = "4")]
	protected virtual void UpdateRotate(float deltaTime)
	{
	}

	// Token: 0x0600371D RID: 14109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DD7")]
	[Address(RVA = "0x1F520D0", Offset = "0x1F521D1", VA = "0x1F520D0", Slot = "5")]
	protected virtual void UpdateMove(float deltaTime)
	{
	}

	// Token: 0x170007B6 RID: 1974
	// (get) Token: 0x0600371E RID: 14110 RVA: 0x00013098 File Offset: 0x00011298
	// (set) Token: 0x0600371F RID: 14111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170005FF")]
	public bool Pause
	{
		[Token(Token = "0x6002DD8")]
		[Address(RVA = "0x1F52170", Offset = "0x1F52271", VA = "0x1F52170")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002DD9")]
		[Address(RVA = "0x1F509E0", Offset = "0x1F50AE1", VA = "0x1F509E0")]
		set
		{
		}
	}

	// Token: 0x06003720 RID: 14112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DDA")]
	[Address(RVA = "0x1F52180", Offset = "0x1F52281", VA = "0x1F52180")]
	public void SetRoute(Vector3 start, Vector3 goal, float speed, bool go = true)
	{
	}

	// Token: 0x06003721 RID: 14113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DDB")]
	[Address(RVA = "0x1F52290", Offset = "0x1F52391", VA = "0x1F52290")]
	public void SetRoute(Transform start, Vector3 goal, float speed, bool go = true)
	{
	}

	// Token: 0x06003722 RID: 14114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DDC")]
	[Address(RVA = "0x1F52350", Offset = "0x1F52451", VA = "0x1F52350")]
	public void SetRoute(Vector3 goal, float speed, bool go = true)
	{
	}

	// Token: 0x06003723 RID: 14115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DDD")]
	[Address(RVA = "0x1F52380", Offset = "0x1F52481", VA = "0x1F52380")]
	public void Go()
	{
	}

	// Token: 0x06003724 RID: 14116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DDE")]
	[Address(RVA = "0x1F521B0", Offset = "0x1F522B1", VA = "0x1F521B0")]
	public void GoRestart()
	{
	}

	// Token: 0x06003725 RID: 14117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DDF")]
	[Address(RVA = "0x1F52460", Offset = "0x1F52561", VA = "0x1F52460")]
	public void SetTestRoute(NpcMoveControl.MOVE_TYPE type, Vector3 start, Vector3 goal, float speed)
	{
	}

	// Token: 0x06003726 RID: 14118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DE0")]
	[Address(RVA = "0x1F52480", Offset = "0x1F52581", VA = "0x1F52480")]
	public void OnTestGo()
	{
	}

	// Token: 0x06003727 RID: 14119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DE1")]
	[Address(RVA = "0x1F52560", Offset = "0x1F52661", VA = "0x1F52560")]
	public void OnTestGoRestart()
	{
	}

	// Token: 0x06003728 RID: 14120 RVA: 0x000130B0 File Offset: 0x000112B0
	[Token(Token = "0x6002DE2")]
	[Address(RVA = "0x1F51190", Offset = "0x1F51291", VA = "0x1F51190")]
	private NpcMoveControl.STATE StateInit(NpcMoveControl.MOVE_TYPE move_type)
	{
		return NpcMoveControl.STATE.NONE;
	}

	// Token: 0x06003729 RID: 14121 RVA: 0x000130C8 File Offset: 0x000112C8
	[Token(Token = "0x6002DE3")]
	[Address(RVA = "0x1F51210", Offset = "0x1F51311", VA = "0x1F51210")]
	private NpcMoveControl.STATE StateStart(NpcMoveControl.MOVE_TYPE move_type)
	{
		return NpcMoveControl.STATE.NONE;
	}

	// Token: 0x0600372A RID: 14122 RVA: 0x000130E0 File Offset: 0x000112E0
	[Token(Token = "0x6002DE4")]
	[Address(RVA = "0x1F51360", Offset = "0x1F51461", VA = "0x1F51360")]
	private NpcMoveControl.STATE StateCalc(NpcMoveControl.MOVE_TYPE move_type)
	{
		return NpcMoveControl.STATE.NONE;
	}

	// Token: 0x0600372B RID: 14123 RVA: 0x000130F8 File Offset: 0x000112F8
	[Token(Token = "0x6002DE5")]
	[Address(RVA = "0x1F51670", Offset = "0x1F51771", VA = "0x1F51670")]
	private NpcMoveControl.STATE StateMove(NpcMoveControl.MOVE_TYPE move_type)
	{
		return NpcMoveControl.STATE.NONE;
	}

	// Token: 0x0600372C RID: 14124 RVA: 0x00013110 File Offset: 0x00011310
	[Token(Token = "0x6002DE6")]
	[Address(RVA = "0x1F52640", Offset = "0x1F52741", VA = "0x1F52640")]
	private Vector3 GetObstacleAvoidToward(Vector3 pos, Vector3 center, Vector3 toward)
	{
		return default(Vector3);
	}

	// Token: 0x0600372D RID: 14125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DE7")]
	[Address(RVA = "0x1F52BD0", Offset = "0x1F52CD1", VA = "0x1F52BD0")]
	public void SetOutDoorMode()
	{
	}

	// Token: 0x0600372E RID: 14126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DE8")]
	[Address(RVA = "0x1F52CB0", Offset = "0x1F52DB1", VA = "0x1F52CB0")]
	public void SetInDoorMode()
	{
	}

	// Token: 0x0600372F RID: 14127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DE9")]
	[Address(RVA = "0x1F52D90", Offset = "0x1F52E91", VA = "0x1F52D90")]
	public void ClearVelocity()
	{
	}

	// Token: 0x06003730 RID: 14128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002DEA")]
	[Address(RVA = "0x1F52E10", Offset = "0x1F52F11", VA = "0x1F52E10")]
	public NpcMoveControl()
	{
	}

	// Token: 0x04007A15 RID: 31253
	[Token(Token = "0x4006E97")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16AF20", Offset = "0x16B021")]
	private NpcMoveControl.STATE <State>k__BackingField;

	// Token: 0x04007A16 RID: 31254
	[Token(Token = "0x4006E98")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public NpcMoveControl.MOVE_TYPE MoveType;

	// Token: 0x04007A17 RID: 31255
	[Token(Token = "0x4006E99")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private NavMeshAgent m_NavMeshAgent;

	// Token: 0x04007A18 RID: 31256
	[Token(Token = "0x4006E9A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private CharacterMovement m_CharacterMovement;

	// Token: 0x04007A19 RID: 31257
	[Token(Token = "0x4006E9B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x16AF60", Offset = "0x16B061")]
	private float m_OutDoorSpeedRate;

	// Token: 0x04007A1A RID: 31258
	[Token(Token = "0x4006E9C")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x16AFA0", Offset = "0x16B0A1")]
	private float m_InDoorSpeedRate;

	// Token: 0x04007A1B RID: 31259
	[Token(Token = "0x4006E9D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float m_SpeedScale;

	// Token: 0x04007A1C RID: 31260
	[Token(Token = "0x4006E9E")]
	[FieldOffset(Offset = "0x3C")]
	private NpcMoveControl.MOVE_TYPE move_type_;

	// Token: 0x04007A1D RID: 31261
	[Token(Token = "0x4006E9F")]
	[FieldOffset(Offset = "0x40")]
	private NavMeshPath path_;

	// Token: 0x04007A1E RID: 31262
	[Token(Token = "0x4006EA0")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 start_;

	// Token: 0x04007A1F RID: 31263
	[Token(Token = "0x4006EA1")]
	[FieldOffset(Offset = "0x54")]
	private Quaternion start_rot_;

	// Token: 0x04007A20 RID: 31264
	[Token(Token = "0x4006EA2")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 goal_;

	// Token: 0x04007A21 RID: 31265
	[Token(Token = "0x4006EA3")]
	[FieldOffset(Offset = "0x70")]
	private float speed_;

	// Token: 0x04007A22 RID: 31266
	[Token(Token = "0x4006EA4")]
	[FieldOffset(Offset = "0x78")]
	private Tweener tween_;

	// Token: 0x04007A23 RID: 31267
	[Token(Token = "0x4006EA5")]
	[FieldOffset(Offset = "0x80")]
	private Animator anim_;

	// Token: 0x04007A24 RID: 31268
	[Token(Token = "0x4006EA6")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 old_pos;

	// Token: 0x04007A25 RID: 31269
	[Token(Token = "0x4006EA7")]
	[FieldOffset(Offset = "0x94")]
	private bool pause_;

	// Token: 0x04007A26 RID: 31270
	[Token(Token = "0x4006EA8")]
	[FieldOffset(Offset = "0x95")]
	private bool moveEnabled;

	// Token: 0x04007A27 RID: 31271
	[Token(Token = "0x4006EA9")]
	private const float ObstacleEnableDistance = 40f;

	// Token: 0x04007A28 RID: 31272
	[Token(Token = "0x4006EAA")]
	private const float ObstacleCheckDistance = 1.5f;

	// Token: 0x04007A29 RID: 31273
	[Token(Token = "0x4006EAB")]
	private const float ObstacleCheckRadius = 0.75f;

	// Token: 0x04007A2A RID: 31274
	[Token(Token = "0x4006EAC")]
	private const float DecelerateRemainingDistance = 3f;

	// Token: 0x04007A2B RID: 31275
	[Token(Token = "0x4006EAD")]
	[FieldOffset(Offset = "0x0")]
	private static float[] ObstacleCheckAngle;

	// Token: 0x04007A2C RID: 31276
	[Token(Token = "0x4006EAE")]
	private const float ObstacleAvoidDuration = 1.5f;

	// Token: 0x04007A2D RID: 31277
	[Token(Token = "0x4006EAF")]
	private const float ObstacleAvoicCoolTime = 0.25f;

	// Token: 0x04007A2E RID: 31278
	[Token(Token = "0x4006EB0")]
	private const float IgnoreObstacleDuration = 1f;

	// Token: 0x04007A2F RID: 31279
	[Token(Token = "0x4006EB1")]
	[FieldOffset(Offset = "0x98")]
	private float m_avoidElapsed;

	// Token: 0x04007A30 RID: 31280
	[Token(Token = "0x4006EB2")]
	[FieldOffset(Offset = "0x9C")]
	private float m_avoidCoolTime;

	// Token: 0x04007A31 RID: 31281
	[Token(Token = "0x4006EB3")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3 m_avoidDirection;

	// Token: 0x04007A32 RID: 31282
	[Token(Token = "0x4006EB4")]
	[FieldOffset(Offset = "0xAC")]
	private bool m_ignore;

	// Token: 0x04007A33 RID: 31283
	[Token(Token = "0x4006EB5")]
	[FieldOffset(Offset = "0xB0")]
	private float m_ignoreElapsed;

	// Token: 0x04007A34 RID: 31284
	[Token(Token = "0x4006EB6")]
	private const float m_MovementSpeedMax = 4f;

	// Token: 0x04007A35 RID: 31285
	[Token(Token = "0x4006EB7")]
	private const float m_MovementAcceleration = 4f;

	// Token: 0x04007A36 RID: 31286
	[Token(Token = "0x4006EB8")]
	private const float m_MovementDeceleration = 8f;

	// Token: 0x04007A37 RID: 31287
	[Token(Token = "0x4006EB9")]
	[FieldOffset(Offset = "0xB4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16AFF0", Offset = "0x16B0F1")]
	private bool <IsInDoor>k__BackingField;

	// Token: 0x04007A38 RID: 31288
	[Token(Token = "0x4006EBA")]
	private const float m_MovementAngularSpeed = 80f;

	// Token: 0x0200080D RID: 2061
	[Token(Token = "0x2001242")]
	public enum STATE
	{
		// Token: 0x04007A3A RID: 31290
		[Token(Token = "0x40197E4")]
		NONE,
		// Token: 0x04007A3B RID: 31291
		[Token(Token = "0x40197E5")]
		IDOL,
		// Token: 0x04007A3C RID: 31292
		[Token(Token = "0x40197E6")]
		INIT,
		// Token: 0x04007A3D RID: 31293
		[Token(Token = "0x40197E7")]
		START,
		// Token: 0x04007A3E RID: 31294
		[Token(Token = "0x40197E8")]
		CALC,
		// Token: 0x04007A3F RID: 31295
		[Token(Token = "0x40197E9")]
		MOVE
	}

	// Token: 0x0200080E RID: 2062
	[Token(Token = "0x2001243")]
	public enum MOVE_TYPE
	{
		// Token: 0x04007A41 RID: 31297
		[Token(Token = "0x40197EB")]
		AUTO,
		// Token: 0x04007A42 RID: 31298
		[Token(Token = "0x40197EC")]
		NAVIMESH,
		// Token: 0x04007A43 RID: 31299
		[Token(Token = "0x40197ED")]
		DOTWEEN,
		// Token: 0x04007A44 RID: 31300
		[Token(Token = "0x40197EE")]
		MANUAL,
		// Token: 0x04007A45 RID: 31301
		[Token(Token = "0x40197EF")]
		CHARACTERMOVEMENT
	}
}
