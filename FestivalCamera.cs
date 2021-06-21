using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000507 RID: 1287
[Token(Token = "0x20003AC")]
public class FestivalCamera : MonoBehaviour
{
	// Token: 0x1700050B RID: 1291
	// (get) Token: 0x06001F54 RID: 8020 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001F55 RID: 8021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000427")]
	public Animator Animator
	{
		[Token(Token = "0x6001ACA")]
		[Address(RVA = "0x1F7E0C0", Offset = "0x1F7E1C1", VA = "0x1F7E0C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FB20", Offset = "0x19FC21")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001ACB")]
		[Address(RVA = "0x1F7E0D0", Offset = "0x1F7E1D1", VA = "0x1F7E0D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FB30", Offset = "0x19FC31")]
		private set
		{
		}
	}

	// Token: 0x1700050C RID: 1292
	// (get) Token: 0x06001F56 RID: 8022 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001F57 RID: 8023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000428")]
	public CinemachineVirtualCameraBase CameraBase
	{
		[Token(Token = "0x6001ACC")]
		[Address(RVA = "0x1F7E0E0", Offset = "0x1F7E1E1", VA = "0x1F7E0E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FB40", Offset = "0x19FC41")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001ACD")]
		[Address(RVA = "0x1F7E0F0", Offset = "0x1F7E1F1", VA = "0x1F7E0F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FB50", Offset = "0x19FC51")]
		private set
		{
		}
	}

	// Token: 0x1700050D RID: 1293
	// (get) Token: 0x06001F58 RID: 8024 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001F59 RID: 8025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000429")]
	public CinemachineVirtualCamera Camera
	{
		[Token(Token = "0x6001ACE")]
		[Address(RVA = "0x1F7E100", Offset = "0x1F7E201", VA = "0x1F7E100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FB60", Offset = "0x19FC61")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001ACF")]
		[Address(RVA = "0x1F7E110", Offset = "0x1F7E211", VA = "0x1F7E110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FB70", Offset = "0x19FC71")]
		private set
		{
		}
	}

	// Token: 0x1700050E RID: 1294
	// (get) Token: 0x06001F5A RID: 8026 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
	// (set) Token: 0x06001F5B RID: 8027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700042A")]
	private protected bool IsShaking
	{
		[Token(Token = "0x6001AD0")]
		[Address(RVA = "0x1F7E120", Offset = "0x1F7E221", VA = "0x1F7E120")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FB80", Offset = "0x19FC81")]
		protected get
		{
			return default(bool);
		}
		[Token(Token = "0x6001AD1")]
		[Address(RVA = "0x1F7E130", Offset = "0x1F7E231", VA = "0x1F7E130")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FB90", Offset = "0x19FC91")]
		private set
		{
		}
	}

	// Token: 0x06001F5C RID: 8028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AD2")]
	[Address(RVA = "0x1F7E140", Offset = "0x1F7E241", VA = "0x1F7E140", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06001F5D RID: 8029 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AD3")]
	[Address(RVA = "0x1F7CF90", Offset = "0x1F7D091", VA = "0x1F7CF90")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19FBA0", Offset = "0x19FCA1")]
	public IEnumerator CountDownCamera()
	{
		return null;
	}

	// Token: 0x06001F5E RID: 8030 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AD4")]
	[Address(RVA = "0x1F7E2E0", Offset = "0x1F7E3E1", VA = "0x1F7E2E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19FC10", Offset = "0x19FD11")]
	public IEnumerator CameraShake()
	{
		return null;
	}

	// Token: 0x06001F5F RID: 8031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AD5")]
	[Address(RVA = "0x1F7E390", Offset = "0x1F7E491", VA = "0x1F7E390")]
	public FestivalCamera()
	{
	}

	// Token: 0x0400664E RID: 26190
	[Token(Token = "0x40060A8")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1657A0", Offset = "0x1658A1")]
	private Animator <Animator>k__BackingField;

	// Token: 0x0400664F RID: 26191
	[Token(Token = "0x40060A9")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1657B0", Offset = "0x1658B1")]
	private CinemachineVirtualCameraBase <CameraBase>k__BackingField;

	// Token: 0x04006650 RID: 26192
	[Token(Token = "0x40060AA")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1657C0", Offset = "0x1658C1")]
	private CinemachineVirtualCamera <Camera>k__BackingField;

	// Token: 0x04006651 RID: 26193
	[Token(Token = "0x40060AB")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1657D0", Offset = "0x1658D1")]
	private bool <IsShaking>k__BackingField;

	// Token: 0x04006652 RID: 26194
	[Token(Token = "0x40060AC")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float shakePower;

	// Token: 0x04006653 RID: 26195
	[Token(Token = "0x40060AD")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float shakeSpeed;

	// Token: 0x04006654 RID: 26196
	[Token(Token = "0x40060AE")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float shakeTime;

	// Token: 0x02000508 RID: 1288
	[Token(Token = "0x20010E4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157C80", Offset = "0x157D81")]
	private sealed class <CountDownCamera>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001F60 RID: 8032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F75")]
		[Address(RVA = "0x1F7E2B0", Offset = "0x1F7E3B1", VA = "0x1F7E2B0")]
		[DebuggerHidden]
		public <CountDownCamera>d__20(int <>1__state)
		{
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F76")]
		[Address(RVA = "0x1F7E5C0", Offset = "0x1F7E6C1", VA = "0x1F7E5C0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		[Token(Token = "0x6006F77")]
		[Address(RVA = "0x1F7E5D0", Offset = "0x1F7E6D1", VA = "0x1F7E5D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001F63 RID: 8035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA1")]
		private object Current
		{
			[Token(Token = "0x6006F78")]
			[Address(RVA = "0x1F7E910", Offset = "0x1F7EA11", VA = "0x1F7E910", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F79")]
		[Address(RVA = "0x1F7E920", Offset = "0x1F7EA21", VA = "0x1F7E920", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001F65 RID: 8037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA2")]
		private object Current
		{
			[Token(Token = "0x6006F7A")]
			[Address(RVA = "0x1F7E980", Offset = "0x1F7EA81", VA = "0x1F7E980", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006655 RID: 26197
		[Token(Token = "0x4019219")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006656 RID: 26198
		[Token(Token = "0x401921A")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006657 RID: 26199
		[Token(Token = "0x401921B")]
		[FieldOffset(Offset = "0x20")]
		public FestivalCamera <>4__this;

		// Token: 0x04006658 RID: 26200
		[Token(Token = "0x401921C")]
		[FieldOffset(Offset = "0x28")]
		private string <currentGame>5__2;
	}

	// Token: 0x02000509 RID: 1289
	[Token(Token = "0x20010E5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157C90", Offset = "0x157D91")]
	private sealed class <CameraShake>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001F66 RID: 8038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F7B")]
		[Address(RVA = "0x1F7E360", Offset = "0x1F7E461", VA = "0x1F7E360")]
		[DebuggerHidden]
		public <CameraShake>d__21(int <>1__state)
		{
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F7C")]
		[Address(RVA = "0x1F7E3B0", Offset = "0x1F7E4B1", VA = "0x1F7E3B0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		[Token(Token = "0x6006F7D")]
		[Address(RVA = "0x1F7E3C0", Offset = "0x1F7E4C1", VA = "0x1F7E3C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001F69 RID: 8041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA3")]
		private object Current
		{
			[Token(Token = "0x6006F7E")]
			[Address(RVA = "0x1F7E540", Offset = "0x1F7E641", VA = "0x1F7E540", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F7F")]
		[Address(RVA = "0x1F7E550", Offset = "0x1F7E651", VA = "0x1F7E550", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001F6B RID: 8043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA4")]
		private object Current
		{
			[Token(Token = "0x6006F80")]
			[Address(RVA = "0x1F7E5B0", Offset = "0x1F7E6B1", VA = "0x1F7E5B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006659 RID: 26201
		[Token(Token = "0x401921D")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400665A RID: 26202
		[Token(Token = "0x401921E")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400665B RID: 26203
		[Token(Token = "0x401921F")]
		[FieldOffset(Offset = "0x20")]
		public FestivalCamera <>4__this;

		// Token: 0x0400665C RID: 26204
		[Token(Token = "0x4019220")]
		[FieldOffset(Offset = "0x28")]
		private float <countTime>5__2;

		// Token: 0x0400665D RID: 26205
		[Token(Token = "0x4019221")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 <pos>5__3;
	}
}
