using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000847 RID: 2119
[Token(Token = "0x2000570")]
public class MagicTestScene : MonoBehaviour
{
	// Token: 0x06003839 RID: 14393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EC3")]
	[Address(RVA = "0x1F158C0", Offset = "0x1F159C1", VA = "0x1F158C0")]
	private void Awake()
	{
	}

	// Token: 0x0600383A RID: 14394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EC4")]
	[Address(RVA = "0x1F15D50", Offset = "0x1F15E51", VA = "0x1F15D50")]
	private void Update()
	{
	}

	// Token: 0x0600383B RID: 14395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EC5")]
	[Address(RVA = "0x1F15A40", Offset = "0x1F15B41", VA = "0x1F15A40")]
	private void InitCamera()
	{
	}

	// Token: 0x0600383C RID: 14396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EC6")]
	[Address(RVA = "0x1F16160", Offset = "0x1F16261", VA = "0x1F16160")]
	private void UpdateCamera()
	{
	}

	// Token: 0x0600383D RID: 14397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EC7")]
	[Address(RVA = "0x1F16630", Offset = "0x1F16731", VA = "0x1F16630")]
	public void OnMagicPlay()
	{
	}

	// Token: 0x0600383E RID: 14398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EC8")]
	[Address(RVA = "0x1F16740", Offset = "0x1F16841", VA = "0x1F16740")]
	public void OnChangePosition(float value)
	{
	}

	// Token: 0x0600383F RID: 14399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EC9")]
	[Address(RVA = "0x1F16750", Offset = "0x1F16851", VA = "0x1F16750")]
	public void OnChangeMoveFrontBack(bool value)
	{
	}

	// Token: 0x06003840 RID: 14400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002ECA")]
	[Address(RVA = "0x1F16760", Offset = "0x1F16861", VA = "0x1F16760")]
	public void OnChangeMoveSpeedFrontBack(float value)
	{
	}

	// Token: 0x06003841 RID: 14401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002ECB")]
	[Address(RVA = "0x1F16770", Offset = "0x1F16871", VA = "0x1F16770")]
	public void OnChangeMoveSpeedLeftRight(float value)
	{
	}

	// Token: 0x06003842 RID: 14402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002ECC")]
	[Address(RVA = "0x1F16780", Offset = "0x1F16881", VA = "0x1F16780")]
	public void OnChangeMoveLeftRight(bool value)
	{
	}

	// Token: 0x06003843 RID: 14403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002ECD")]
	[Address(RVA = "0x1F16790", Offset = "0x1F16891", VA = "0x1F16790")]
	public MagicTestScene()
	{
	}

	// Token: 0x04007B48 RID: 31560
	[Token(Token = "0x4006F74")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Camera m_camera;

	// Token: 0x04007B49 RID: 31561
	[Token(Token = "0x4006F75")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Character m_chara;

	// Token: 0x04007B4A RID: 31562
	[Token(Token = "0x4006F76")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Character m_target;

	// Token: 0x04007B4B RID: 31563
	[Token(Token = "0x4006F77")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AnimationCurve m_curveTargetPosition;

	// Token: 0x04007B4C RID: 31564
	[Token(Token = "0x4006F78")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x16B2B0", Offset = "0x16B3B1")]
	private float m_targetPosition;

	// Token: 0x04007B4D RID: 31565
	[Token(Token = "0x4006F79")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private bool m_isMoveFrontBack;

	// Token: 0x04007B4E RID: 31566
	[Token(Token = "0x4006F7A")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AnimationCurve m_curveMoveFrontBack;

	// Token: 0x04007B4F RID: 31567
	[Token(Token = "0x4006F7B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x16B310", Offset = "0x16B411")]
	private float m_speedMoveFrontBack;

	// Token: 0x04007B50 RID: 31568
	[Token(Token = "0x4006F7C")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private bool m_isMoveLeftRight;

	// Token: 0x04007B51 RID: 31569
	[Token(Token = "0x4006F7D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AnimationCurve m_curveMoveLeftRight;

	// Token: 0x04007B52 RID: 31570
	[Token(Token = "0x4006F7E")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x16B370", Offset = "0x16B471")]
	private float m_speedMoveLeftRight;

	// Token: 0x04007B53 RID: 31571
	[Token(Token = "0x4006F7F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject m_panel;

	// Token: 0x04007B54 RID: 31572
	[Token(Token = "0x4006F80")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Dropdown m_magic;

	// Token: 0x04007B55 RID: 31573
	[Token(Token = "0x4006F81")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private ScrollRect m_magicSelect;

	// Token: 0x04007B56 RID: 31574
	[Token(Token = "0x4006F82")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private MagicTestButton m_magicButtonBase;

	// Token: 0x04007B57 RID: 31575
	[Token(Token = "0x4006F83")]
	[FieldOffset(Offset = "0x80")]
	private MagicTestScene.Mode m_mode;

	// Token: 0x04007B58 RID: 31576
	[Token(Token = "0x4006F84")]
	[FieldOffset(Offset = "0x84")]
	private float m_elapsedMoveFrontBack;

	// Token: 0x04007B59 RID: 31577
	[Token(Token = "0x4006F85")]
	[FieldOffset(Offset = "0x88")]
	private float m_elapsedMovLeftRight;

	// Token: 0x04007B5A RID: 31578
	[Token(Token = "0x4006F86")]
	[FieldOffset(Offset = "0x8C")]
	private Quaternion m_cameraRotate;

	// Token: 0x02000848 RID: 2120
	[Token(Token = "0x200125A")]
	private enum Mode
	{
		// Token: 0x04007B5C RID: 31580
		[Token(Token = "0x401983A")]
		None,
		// Token: 0x04007B5D RID: 31581
		[Token(Token = "0x401983B")]
		Init,
		// Token: 0x04007B5E RID: 31582
		[Token(Token = "0x401983C")]
		InitWait
	}
}
