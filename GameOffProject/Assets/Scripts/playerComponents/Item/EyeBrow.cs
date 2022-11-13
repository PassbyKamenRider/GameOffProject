using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DefenseSkill;

public class EyeBrow : Item
{
    public enum EyeBrowId {
        TEST_EYEBROW_1,
        TEST_EYEBROW_HAPPY,
        TEST_EYEBROW_SAD,
        TEST_EYEBROW_ANGRY
    }
    private EyeBrowId id;

    public EyeBrow(EyeBrowId id) {
        this.id = id;

        switch(id) {
            case EyeBrowId.TEST_EYEBROW_1:
                happyATK = 50f;
                happyDEF = 50f;
                sadATK = 50f;
                sadDEF = 50f;
                angryATK = 50f;
                angryDEF = 50f;
                skill = new DefenseSkill(DefenseSkillId.TEST_DEFENSE_SKILL_1);
                displayName = "test eyebrow";
                break;
            case EyeBrowId.TEST_EYEBROW_HAPPY:
                happyATK = 50f;
                happyDEF = 50f;
                sadATK = 50f;
                sadDEF = 50f;
                angryATK = 50f;
                angryDEF = 50f;
                skill = new DefenseSkill(DefenseSkillId.TEST_DEFENSE_SKILL_1);
                displayName = "test eyebrow happy";
                break;
            case EyeBrowId.TEST_EYEBROW_SAD:
                happyATK = 50f;
                happyDEF = 50f;
                sadATK = 50f;
                sadDEF = 50f;
                angryATK = 50f;
                angryDEF = 50f;
                skill = new DefenseSkill(DefenseSkillId.TEST_DEFENSE_SKILL_1);
                displayName = "test eyebrow sad";
                break;
            case EyeBrowId.TEST_EYEBROW_ANGRY:
                happyATK = 50f;
                happyDEF = 50f;
                sadATK = 50f;
                sadDEF = 50f;
                angryATK = 50f;
                angryDEF = 50f;
                skill = new DefenseSkill(DefenseSkillId.TEST_DEFENSE_SKILL_1);
                displayName = "test eyebrow angry";
                break;
        }
    }
}