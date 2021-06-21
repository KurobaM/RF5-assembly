using System;
using System.Runtime.InteropServices;
using Cinemachine;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000199 RID: 409
[Token(Token = "0x2000144")]
public abstract class CameraControllerBase : MonoBehaviour
{
	// Token: 0x1700019F RID: 415
	// (get) Token: 0x06000868 RID: 2152 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700018A")]
	protected Character CtrlCharacter
	{
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x1E75AB0", Offset = "0x1E75BB1", VA = "0x1E75AB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x06000869 RID: 2153 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700018B")]
	protected Camera MainCamera
	{
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x1E75B10", Offset = "0x1E75C11", VA = "0x1E75B10")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x0600086B RID: 2155 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600086A RID: 2154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700018C")]
	public CinemachineVirtualCameraBase ParentVirtualCameraBase
	{
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x1E75B80", Offset = "0x1E75C81", VA = "0x1E75B80")]
		get
		{
			return null;
		}
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x1E75B70", Offset = "0x1E75C71", VA = "0x1E75B70")]
		protected set
		{
		}
	}

	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x0600086D RID: 2157 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600086C RID: 2156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700018D")]
	public CinemachineVirtualCamera UseVirtualCamera
	{
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x1E75BA0", Offset = "0x1E75CA1", VA = "0x1E75BA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AB50", Offset = "0x19AC51")]
		get
		{
			return null;
		}
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x1E75B90", Offset = "0x1E75C91", VA = "0x1E75B90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AB40", Offset = "0x19AC41")]
		protected set
		{
		}
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600073E")]
	[Address(RVA = "0x1E75BB0", Offset = "0x1E75CB1", VA = "0x1E75BB0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600073F")]
	[Address(RVA = "0x1E75C70", Offset = "0x1E75D71", VA = "0x1E75C70", Slot = "5")]
	protected virtual void Start()
	{
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000740")]
	[Address(RVA = "0x1E75C80", Offset = "0x1E75D81", VA = "0x1E75C80", Slot = "6")]
	public virtual void EnableCameraSetup(UseCameraType prevCameraType, [Optional] CinemachineVirtualCamera vcam)
	{
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000741")]
	[Address(RVA = "0x1E75C90", Offset = "0x1E75D91", VA = "0x1E75C90", Slot = "7")]
	public virtual void DisableCameraSetup(UseCameraType nextCameraType, [Optional] CinemachineVirtualCamera vcam)
	{
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000742")]
	[Address(RVA = "0x1E75CA0", Offset = "0x1E75DA1", VA = "0x1E75CA0", Slot = "8")]
	public virtual void PreFrameUpdate()
	{
	}

	// Token: 0x06000873 RID: 2163
	[Token(Token = "0x6000743")]
	public abstract void FrameUpdate();

	// Token: 0x06000874 RID: 2164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000744")]
	[Address(RVA = "0x1E75CB0", Offset = "0x1E75DB1", VA = "0x1E75CB0", Slot = "10")]
	public virtual void TimeStepUpdate()
	{
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000745")]
	[Address(RVA = "0x1E75CC0", Offset = "0x1E75DC1", VA = "0x1E75CC0")]
	protected CameraControllerBase()
	{
	}

	// Token: 0x040004F4 RID: 1268
	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C760", Offset = "0x15C861")]
	private CinemachineVirtualCamera <UseVirtualCamera>k__BackingField;

	// Token: 0x040004F5 RID: 1269
	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CinemachineVirtualCameraBase m_VirtualCameraBase;
}
