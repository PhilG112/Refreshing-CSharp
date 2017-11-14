using System;

namespace Domain.ContitionalStatements
{
    public class Ten
    {
        private int _mathsMark;
        private int _physicsMark;
        private int _chemistryMark;
        private int _totalMark;

        public Ten(int mathsMark, int physicsMark, int chemistyMark)
        {
            _mathsMark = mathsMark;
            _physicsMark = physicsMark;
            _chemistryMark = chemistyMark;
        }

        public string IsEligible()
        {
            var maths = CheckMaths();
            var physics = CheckPhysics();
            var chemistry = CheckChemistry();

            var totalmarks = TotalMarks();

            if ((maths && physics && chemistry) && (totalmarks >= 180))
            {
                return "The candidate is eligible for admission";
            }
            else if (maths && (_physicsMark + _chemistryMark >= 140))
            {
                return "The candidate is eligible for admission";
            }

            return "The candidate is not eligible for admission";
        }

        private bool CheckMaths() => _mathsMark >= 65 ? true : false;
        private bool CheckPhysics() => _physicsMark >= 55 ? true : false;
        private bool CheckChemistry() => _chemistryMark >= 50 ? true : false;
        private int TotalMarks() => _totalMark = _mathsMark + _physicsMark + _chemistryMark;
    }
}