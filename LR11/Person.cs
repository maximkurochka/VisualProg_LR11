using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR11
{
    [Serializable]
    class Person : IEquatable<Person>
    {
        public string mFio { get; set; }
        public bool mIsMale { get; set; }
        public string mBirth { get; set; }
        public string mStreet { get; set; }
        public string mHouse { get; set; }
        public ushort mFlat { get; set; }
        public float mSquare { get; set; }

        public Person()
        {
            mFio = "";
            mIsMale = true;
            mBirth = "";
            mStreet = "";
            mHouse = "";
            mFlat = 0;
            mSquare = 0f;
        }

        public Person(string fio, bool isMale, string birth, string street, string house, ushort flat, float square)
        {
            mFio = fio;
            mIsMale = isMale;
            mBirth = birth;
            mStreet = street;
            mHouse = house;
            mFlat = flat;
            mSquare = square;
        }

        public Person(SearchKey searchKey, string value)
        {
            mFio = "";
            mIsMale = true;
            mBirth = "";
            mStreet = "";
            mHouse = "";
            mFlat = 0;
            mSquare = 0f;

            switch (searchKey)
            {
                case SearchKey.Fio:
                    mFio = value;
                    break;

                case SearchKey.Birth:
                    mBirth = value;
                    break;

                case SearchKey.Street:
                    mStreet = value;
                    break;

                case SearchKey.House:
                    mHouse = value;
                    break;

                case SearchKey.Unknown:
                default:
                    break;
            }
        }

        public bool Equals(Person other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return (mFio.Equals(other.mFio) && mFio.Any())
                || (mBirth.Equals(other.mBirth) && mBirth.Any())
                || (mStreet.Equals(other.mStreet) && mStreet.Any())
                || (mHouse.Equals(other.mHouse) && mHouse.Any());
        }

        public override bool Equals(object obj) => Equals(obj as Person);

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = mFio.GetHashCode();
                hashCode = (hashCode * 397) ^ mBirth.GetHashCode();
                hashCode = (hashCode * 397) ^ mStreet.GetHashCode();
                hashCode = (hashCode * 397) ^ mHouse.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator==(Person obj1, Person obj2)
        {
            if (ReferenceEquals(obj1, obj2))
            {
                return true;
            }

            if (ReferenceEquals(obj1, null) || ReferenceEquals(obj2, null))
            {
                return false;
            }

            return obj1.Equals(obj2);
        }

        public static bool operator!=(Person obj1, Person obj2) => !(obj1 == obj2);
    }
}
