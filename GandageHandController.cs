using System;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006ED RID: 1773
[Token(Token = "0x20004E4")]
public class GandageHandController : MonoBehaviour
{
	// Token: 0x06002C13 RID: 11283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600253D")]
	[Address(RVA = "0x1F969D0", Offset = "0x1F96AD1", VA = "0x1F969D0")]
	private void Awake()
	{
	}

	// Token: 0x06002C14 RID: 11284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600253E")]
	[Address(RVA = "0x1F96B50", Offset = "0x1F96C51", VA = "0x1F96B50")]
	private void Update()
	{
	}

	// Token: 0x06002C15 RID: 11285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600253F")]
	[Address(RVA = "0x1F96CE0", Offset = "0x1F96DE1", VA = "0x1F96CE0")]
	public void StartMoveCubicBezier(Vector3 point, Vector3 initPosition, Vector3[] path01, Vector3[] path02, float time01, float time02)
	{
	}

	// Token: 0x06002C16 RID: 11286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002540")]
	[Address(RVA = "0x1F95A10", Offset = "0x1F95B11", VA = "0x1F95A10")]
	public void SetDisplayHand(bool isDisplay, float fadeTime, Vector3 localposition, Vector3 localRotation)
	{
	}

	// Token: 0x06002C17 RID: 11287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002541")]
	[Address(RVA = "0x1F96810", Offset = "0x1F96911", VA = "0x1F96810")]
	public void SetDisplayHand(bool isDisplay, float fadeTime)
	{
	}

	// Token: 0x06002C18 RID: 11288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002542")]
	[Address(RVA = "0x1F95B50", Offset = "0x1F95C51", VA = "0x1F95B50")]
	public void MoveCubicBezier(Vector3[] path, float time, float lookAHead, Vector3 forward, Vector3 up, [Optional] Action callBack)
	{
	}

	// Token: 0x06002C19 RID: 11289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002543")]
	[Address(RVA = "0x1F970A0", Offset = "0x1F971A1", VA = "0x1F970A0")]
	public GandageHandController()
	{
	}

	// Token: 0x04007327 RID: 29479
	[Token(Token = "0x4006A7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GandageHandController.ArmType _ArmType;

	// Token: 0x04007328 RID: 29480
	[Token(Token = "0x4006A7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GandageHandController.MaterialFadeController _MaterialFadeController;

	// Token: 0x04007329 RID: 29481
	[Token(Token = "0x4006A7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TweenerCore<Vector3, Path, PathOptions> Tweener;

	// Token: 0x0400732A RID: 29482
	[Token(Token = "0x4006A7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private PathOptions Option;

	// Token: 0x0400732B RID: 29483
	[Token(Token = "0x4006A7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool IsSetup;

	// Token: 0x020006EE RID: 1774
	[Token(Token = "0x2001191")]
	public class MaterialFadeController
	{
		// Token: 0x06002C1A RID: 11290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C1")]
		[Address(RVA = "0x1F96AD0", Offset = "0x1F96BD1", VA = "0x1F96AD0")]
		public MaterialFadeController(Material material)
		{
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C2")]
		[Address(RVA = "0x1F97250", Offset = "0x1F97351", VA = "0x1F97250")]
		protected void SetEnableDither(Material material, bool enable)
		{
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C3")]
		[Address(RVA = "0x1F97340", Offset = "0x1F97441", VA = "0x1F97340")]
		protected void SetEnableDitherAlpha(Material material, bool enable)
		{
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C4")]
		[Address(RVA = "0x1F96EA0", Offset = "0x1F96FA1", VA = "0x1F96EA0")]
		public void OnStartFade(GandageHandController.MaterialFadeController.FadeType fadeType, float duration, bool isBetween)
		{
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C5")]
		[Address(RVA = "0x1F96B70", Offset = "0x1F96C71", VA = "0x1F96B70")]
		public void OnUpdateFadeing()
		{
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C6")]
		[Address(RVA = "0x1F97430", Offset = "0x1F97531", VA = "0x1F97430")]
		private void EndFade()
		{
		}

		// Token: 0x0400732C RID: 29484
		[Token(Token = "0x401951A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Material _Material;

		// Token: 0x0400732D RID: 29485
		[Token(Token = "0x401951B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float Timer;

		// Token: 0x0400732E RID: 29486
		[Token(Token = "0x401951C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float Duration;

		// Token: 0x0400732F RID: 29487
		[Token(Token = "0x401951D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float FadeStartParam;

		// Token: 0x04007330 RID: 29488
		[Token(Token = "0x401951E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private GandageHandController.MaterialFadeController.FadeType _FadeType;

		// Token: 0x020006EF RID: 1775
		[Token(Token = "0x200164B")]
		public enum FadeType
		{
			// Token: 0x04007332 RID: 29490
			[Token(Token = "0x401C3F6")]
			FadeIn,
			// Token: 0x04007333 RID: 29491
			[Token(Token = "0x401C3F7")]
			FadeIn_End,
			// Token: 0x04007334 RID: 29492
			[Token(Token = "0x401C3F8")]
			FadeOut,
			// Token: 0x04007335 RID: 29493
			[Token(Token = "0x401C3F9")]
			FadeOut_End
		}
	}

	// Token: 0x020006F0 RID: 1776
	[Token(Token = "0x2001192")]
	[Serializable]
	public enum ArmType
	{
		// Token: 0x04007337 RID: 29495
		[Token(Token = "0x4019520")]
		Left_OpenHand,
		// Token: 0x04007338 RID: 29496
		[Token(Token = "0x4019521")]
		Left_Fist,
		// Token: 0x04007339 RID: 29497
		[Token(Token = "0x4019522")]
		Right_OpenHand,
		// Token: 0x0400733A RID: 29498
		[Token(Token = "0x4019523")]
		Right_Fist
	}

	// Token: 0x020006F1 RID: 1777
	[Token(Token = "0x2001193")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1583C0", Offset = "0x1584C1")]
	private sealed class <>c__DisplayClass9_0
	{
		// Token: 0x06002C20 RID: 11296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C7")]
		[Address(RVA = "0x1F96E90", Offset = "0x1F96F91", VA = "0x1F96E90")]
		public <>c__DisplayClass9_0()
		{
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C8")]
		[Address(RVA = "0x1F970D0", Offset = "0x1F971D1", VA = "0x1F970D0")]
		internal void <StartMoveCubicBezier>b__0()
		{
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C9")]
		[Address(RVA = "0x1F97210", Offset = "0x1F97311", VA = "0x1F97210")]
		internal void <StartMoveCubicBezier>b__1()
		{
		}

		// Token: 0x0400733B RID: 29499
		[Token(Token = "0x4019524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GandageHandController <>4__this;

		// Token: 0x0400733C RID: 29500
		[Token(Token = "0x4019525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] path02;

		// Token: 0x0400733D RID: 29501
		[Token(Token = "0x4019526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float time02;

		// Token: 0x0400733E RID: 29502
		[Token(Token = "0x4019527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action <>9__1;
	}

	// Token: 0x020006F2 RID: 1778
	[Token(Token = "0x2001194")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1583D0", Offset = "0x1584D1")]
	private sealed class <>c__DisplayClass12_0
	{
		// Token: 0x06002C23 RID: 11299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071CA")]
		[Address(RVA = "0x1F97090", Offset = "0x1F97191", VA = "0x1F97090")]
		public <>c__DisplayClass12_0()
		{
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071CB")]
		[Address(RVA = "0x1F970B0", Offset = "0x1F971B1", VA = "0x1F970B0")]
		internal void <MoveCubicBezier>b__0()
		{
		}

		// Token: 0x0400733F RID: 29503
		[Token(Token = "0x4019528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action callBack;
	}
}
