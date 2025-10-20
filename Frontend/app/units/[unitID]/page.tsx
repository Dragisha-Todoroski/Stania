'use client'
import { useParams } from 'next/navigation'

import { listContent } from '@/components/layout/TopProp';

export default function Unit() {
    const { unitID } = useParams();
  return (
    <section className='unit'>
      I AM UNIT {unitID}
      {listContent.map((list) => {
        <div key={list.id} className='bg-gray-50'>
            <p>{list.title}</p>
        </div>
      })}
      <div className="wrapper"></div>
    </section>
  )
}
