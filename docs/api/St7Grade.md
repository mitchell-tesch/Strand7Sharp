# St7Grade

Grades selected elements.  See Grade Types for additional information.

long St7Grade(long uID, long GradeType, double GradeRatio)

Input Parameters

uID

Strand7 model file ID.

GradeType

One of gt1x2Grade, gt1x2TriGrade, gt1x3Grade, gt2x3Grade, gt2x3TriGrade, gtQuarterQuadGrade,
gtQuarterCircleCut, gtQuarterAnnulusCut, gtFullQuarterCircleCut, gtTriGrade2, gtTriGrade1,
gtTriGrade3, gt2x4Grade, gtBrickCornerGrade, gtQuadTriGrade1, gtTriGrade5, gtQuadCutOut,
gtTriGrade4, gtFullQuarterCircleGrade or gtQuadGradeTri.

GradeRatio

Ratio of the grade for applicable grade types.

Dependencies
Selection

Elements can be selected using functions in Entity Selection.
