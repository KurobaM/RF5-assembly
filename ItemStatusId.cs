﻿using System;
using Il2CppDummyDll;

// Token: 0x02000636 RID: 1590
[Token(Token = "0x200047B")]
public enum ItemStatusId
{
	// Token: 0x04006DF3 RID: 28147
	[Token(Token = "0x40066C4")]
	NONE,
	// Token: 0x04006DF4 RID: 28148
	[Token(Token = "0x40066C5")]
	HARVESTTIME,
	// Token: 0x04006DF5 RID: 28149
	[Token(Token = "0x40066C6")]
	HARVESTNUM,
	// Token: 0x04006DF6 RID: 28150
	[Token(Token = "0x40066C7")]
	HARVESTPRICE,
	// Token: 0x04006DF7 RID: 28151
	[Token(Token = "0x40066C8")]
	WATERLEFT,
	// Token: 0x04006DF8 RID: 28152
	[Token(Token = "0x40066C9")]
	FISHSIZE,
	// Token: 0x04006DF9 RID: 28153
	[Token(Token = "0x40066CA")]
	FOOD_HP_FIXED,
	// Token: 0x04006DFA RID: 28154
	[Token(Token = "0x40066CB")]
	FOOD_HP_PERCENT,
	// Token: 0x04006DFB RID: 28155
	[Token(Token = "0x40066CC")]
	FOOD_RP_FIXED,
	// Token: 0x04006DFC RID: 28156
	[Token(Token = "0x40066CD")]
	FOOD_RP_PERCENT,
	// Token: 0x04006DFD RID: 28157
	[Token(Token = "0x40066CE")]
	FOOD_EFFECTIVETIME,
	// Token: 0x04006DFE RID: 28158
	[Token(Token = "0x40066CF")]
	FOOD_HPMAX_FIXED,
	// Token: 0x04006DFF RID: 28159
	[Token(Token = "0x40066D0")]
	FOOD_HPMAX_PERCENT,
	// Token: 0x04006E00 RID: 28160
	[Token(Token = "0x40066D1")]
	FOOD_RPMAX_FIXED,
	// Token: 0x04006E01 RID: 28161
	[Token(Token = "0x40066D2")]
	FOOD_RPMAX_PERCENT,
	// Token: 0x04006E02 RID: 28162
	[Token(Token = "0x40066D3")]
	FOOD_STR_FIXED,
	// Token: 0x04006E03 RID: 28163
	[Token(Token = "0x40066D4")]
	FOOD_STR_PERCENT,
	// Token: 0x04006E04 RID: 28164
	[Token(Token = "0x40066D5")]
	FOOD_INT_FIXED,
	// Token: 0x04006E05 RID: 28165
	[Token(Token = "0x40066D6")]
	FOOD_INT_PERCENT,
	// Token: 0x04006E06 RID: 28166
	[Token(Token = "0x40066D7")]
	FOOD_VIT_FIXED,
	// Token: 0x04006E07 RID: 28167
	[Token(Token = "0x40066D8")]
	FOOD_VIT_PERCENT,
	// Token: 0x04006E08 RID: 28168
	[Token(Token = "0x40066D9")]
	EQUIP_ATTRIBUTES,
	// Token: 0x04006E09 RID: 28169
	[Token(Token = "0x40066DA")]
	EQUIP_PHYSICAL_ATTACK,
	// Token: 0x04006E0A RID: 28170
	[Token(Token = "0x40066DB")]
	EQUIP_MAGIC_ATTACK,
	// Token: 0x04006E0B RID: 28171
	[Token(Token = "0x40066DC")]
	EQUIP_PHYSICAL_DEFENSE,
	// Token: 0x04006E0C RID: 28172
	[Token(Token = "0x40066DD")]
	EQUIP_MAGIC_DEFENSE,
	// Token: 0x04006E0D RID: 28173
	[Token(Token = "0x40066DE")]
	EQUIP_STR,
	// Token: 0x04006E0E RID: 28174
	[Token(Token = "0x40066DF")]
	EQUIP_INT,
	// Token: 0x04006E0F RID: 28175
	[Token(Token = "0x40066E0")]
	EQUIP_VIT,
	// Token: 0x04006E10 RID: 28176
	[Token(Token = "0x40066E1")]
	EQUIP_STUN,
	// Token: 0x04006E11 RID: 28177
	[Token(Token = "0x40066E2")]
	EQUIP_CRITICAL,
	// Token: 0x04006E12 RID: 28178
	[Token(Token = "0x40066E3")]
	EQUIP_KNOCKBACKVALUE,
	// Token: 0x04006E13 RID: 28179
	[Token(Token = "0x40066E4")]
	EQUIP_KNOCKBACKTIME,
	// Token: 0x04006E14 RID: 28180
	[Token(Token = "0x40066E5")]
	EQUIP_POISON,
	// Token: 0x04006E15 RID: 28181
	[Token(Token = "0x40066E6")]
	EQUIP_SEAL,
	// Token: 0x04006E16 RID: 28182
	[Token(Token = "0x40066E7")]
	EQUIP_PARALYSIS,
	// Token: 0x04006E17 RID: 28183
	[Token(Token = "0x40066E8")]
	EQUIP_SLEEP,
	// Token: 0x04006E18 RID: 28184
	[Token(Token = "0x40066E9")]
	EQUIP_FATIGUE,
	// Token: 0x04006E19 RID: 28185
	[Token(Token = "0x40066EA")]
	EQUIP_DISEASE,
	// Token: 0x04006E1A RID: 28186
	[Token(Token = "0x40066EB")]
	EQUIP_DEATH,
	// Token: 0x04006E1B RID: 28187
	[Token(Token = "0x40066EC")]
	EQUIP_LIFEDRAIN,
	// Token: 0x04006E1C RID: 28188
	[Token(Token = "0x40066ED")]
	EQUIP_RESISTFIRE,
	// Token: 0x04006E1D RID: 28189
	[Token(Token = "0x40066EE")]
	EQUIP_RESISTWATER,
	// Token: 0x04006E1E RID: 28190
	[Token(Token = "0x40066EF")]
	EQUIP_RESISTEARTH,
	// Token: 0x04006E1F RID: 28191
	[Token(Token = "0x40066F0")]
	EQUIP_RESISTAIR,
	// Token: 0x04006E20 RID: 28192
	[Token(Token = "0x40066F1")]
	EQUIP_RESISTLIGHT,
	// Token: 0x04006E21 RID: 28193
	[Token(Token = "0x40066F2")]
	EQUIP_RESISTDARK,
	// Token: 0x04006E22 RID: 28194
	[Token(Token = "0x40066F3")]
	EQUIP_RESISTLOVE,
	// Token: 0x04006E23 RID: 28195
	[Token(Token = "0x40066F4")]
	EQUIP_RESISTMU,
	// Token: 0x04006E24 RID: 28196
	[Token(Token = "0x40066F5")]
	EQUIP_RESISTSTUN,
	// Token: 0x04006E25 RID: 28197
	[Token(Token = "0x40066F6")]
	EQUIP_RESISTCRITICAL,
	// Token: 0x04006E26 RID: 28198
	[Token(Token = "0x40066F7")]
	EQUIP_RESISTKNOCKBACK,
	// Token: 0x04006E27 RID: 28199
	[Token(Token = "0x40066F8")]
	EQUIP_RESISTPOISON,
	// Token: 0x04006E28 RID: 28200
	[Token(Token = "0x40066F9")]
	EQUIP_RESISTSEAL,
	// Token: 0x04006E29 RID: 28201
	[Token(Token = "0x40066FA")]
	EQUIP_RESISTPALARYSIS,
	// Token: 0x04006E2A RID: 28202
	[Token(Token = "0x40066FB")]
	EQUIP_RESISTSLEEP,
	// Token: 0x04006E2B RID: 28203
	[Token(Token = "0x40066FC")]
	EQUIP_RESISTFATIGUE,
	// Token: 0x04006E2C RID: 28204
	[Token(Token = "0x40066FD")]
	EQUIP_RESISTDISEASE,
	// Token: 0x04006E2D RID: 28205
	[Token(Token = "0x40066FE")]
	EQUIP_RESISTDEATH,
	// Token: 0x04006E2E RID: 28206
	[Token(Token = "0x40066FF")]
	EQUIP_RESISTLIFEDRAIN,
	// Token: 0x04006E2F RID: 28207
	[Token(Token = "0x4006700")]
	EQUIP_CHARGESPEED,
	// Token: 0x04006E30 RID: 28208
	[Token(Token = "0x4006701")]
	SYNTHESIS_PHYSICAL_ATTACK,
	// Token: 0x04006E31 RID: 28209
	[Token(Token = "0x4006702")]
	SYNTHESIS_MAGIC_ATTACK,
	// Token: 0x04006E32 RID: 28210
	[Token(Token = "0x4006703")]
	SYNTHESIS_PHYSICAL_DEFENSE,
	// Token: 0x04006E33 RID: 28211
	[Token(Token = "0x4006704")]
	SYNTHESIS_MAGIC_DEFENSE,
	// Token: 0x04006E34 RID: 28212
	[Token(Token = "0x4006705")]
	SYNTHESIS_STR,
	// Token: 0x04006E35 RID: 28213
	[Token(Token = "0x4006706")]
	SYNTHESIS_INT,
	// Token: 0x04006E36 RID: 28214
	[Token(Token = "0x4006707")]
	SYNTHESIS_VIT,
	// Token: 0x04006E37 RID: 28215
	[Token(Token = "0x4006708")]
	SYNTHESIS_STUN,
	// Token: 0x04006E38 RID: 28216
	[Token(Token = "0x4006709")]
	SYNTHESIS_CRITICAL,
	// Token: 0x04006E39 RID: 28217
	[Token(Token = "0x400670A")]
	SYNTHESIS_KNOCKBACKVALUE,
	// Token: 0x04006E3A RID: 28218
	[Token(Token = "0x400670B")]
	SYNTHESIS_KNOCKBACKTIME,
	// Token: 0x04006E3B RID: 28219
	[Token(Token = "0x400670C")]
	SYNTHESIS_POISON,
	// Token: 0x04006E3C RID: 28220
	[Token(Token = "0x400670D")]
	SYNTHESIS_SEAL,
	// Token: 0x04006E3D RID: 28221
	[Token(Token = "0x400670E")]
	SYNTHESIS_PARALYSIS,
	// Token: 0x04006E3E RID: 28222
	[Token(Token = "0x400670F")]
	SYNTHESIS_SLEEP,
	// Token: 0x04006E3F RID: 28223
	[Token(Token = "0x4006710")]
	SYNTHESIS_FATIGUE,
	// Token: 0x04006E40 RID: 28224
	[Token(Token = "0x4006711")]
	SYNTHESIS_DISEASE,
	// Token: 0x04006E41 RID: 28225
	[Token(Token = "0x4006712")]
	SYNTHESIS_DEATH,
	// Token: 0x04006E42 RID: 28226
	[Token(Token = "0x4006713")]
	SYNTHESIS_LIFEDRAIN,
	// Token: 0x04006E43 RID: 28227
	[Token(Token = "0x4006714")]
	SYNTHESIS_RESISTSTUN,
	// Token: 0x04006E44 RID: 28228
	[Token(Token = "0x4006715")]
	SYNTHESIS_RESISTCRITICAL,
	// Token: 0x04006E45 RID: 28229
	[Token(Token = "0x4006716")]
	SYNTHESIS_RESISTKNOCKBACKVALUE,
	// Token: 0x04006E46 RID: 28230
	[Token(Token = "0x4006717")]
	SYNTHESIS_RESISTPOISON,
	// Token: 0x04006E47 RID: 28231
	[Token(Token = "0x4006718")]
	SYNTHESIS_RESISTSEAL,
	// Token: 0x04006E48 RID: 28232
	[Token(Token = "0x4006719")]
	SYNTHESIS_RESISTPALARYSIS,
	// Token: 0x04006E49 RID: 28233
	[Token(Token = "0x400671A")]
	SYNTHESIS_RESISTSLEEP,
	// Token: 0x04006E4A RID: 28234
	[Token(Token = "0x400671B")]
	SYNTHESIS_RESISTFATIGUE,
	// Token: 0x04006E4B RID: 28235
	[Token(Token = "0x400671C")]
	SYNTHESIS_RESISTDISEASE,
	// Token: 0x04006E4C RID: 28236
	[Token(Token = "0x400671D")]
	SYNTHESIS_RESISTDEATH,
	// Token: 0x04006E4D RID: 28237
	[Token(Token = "0x400671E")]
	SYNTHESIS_RESISTLIFEDRAIN,
	// Token: 0x04006E4E RID: 28238
	[Token(Token = "0x400671F")]
	SYNTHESIS_DIFFICULTY,
	// Token: 0x04006E4F RID: 28239
	[Token(Token = "0x4006720")]
	Max
}